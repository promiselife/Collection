using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.IO;
using System.Text;
using YamlDotNet.Serialization;
namespace StarStudio
{
    public class ExportAsset
    {

        //平台路径
        public static string workPath = "";
        public static string AndroidworkPath = Application.streamingAssetsPath + "/AssetBundle/Android/";
        public static string IOSworkPath = Application.streamingAssetsPath + "/AssetBundle/IOS";

        private static readonly string[] FILE_EXCLUDE_PATTERNS = new string[] { ".DS_Store", "README", "id_define", ".meta" };

        //美术资源
        private static ArtPathConfig artConfig = null;

        //PE
        static List<AssetBundleSerializer> AssetBundleConfigQueue = new List<AssetBundleSerializer>();
        static Dictionary<string, string> ResPathAssetBundleConfigQueue = new Dictionary<string, string>();

        public static void ExportRes(int type,BuildTarget target, bool encrypted, string[] inputTopDirs, string[] scenePaths, string resRootPath)
        {
            Debug.Log("开始打包");
            switch (target)
            {
                case BuildTarget.iOS:
                    workPath = IOSworkPath;
                    break;
                case BuildTarget.Android:
                    workPath = AndroidworkPath;
                    break;
                default:
                    break;
            }

            if (type == 1)
            {
                //将每一个资源都单独打出AB
                PEPARK(workPath, target, encrypted, inputTopDirs, scenePaths, resRootPath);
                
            }
            else
            {
                //根据文件夹配置打出AB
                 WX2PARK(workPath, target, encrypted, inputTopDirs, scenePaths, resRootPath);
            }



            AssetDatabase.Refresh();
        }

        //pe park
        private static void PEPARK(string workPath, BuildTarget target, bool encrypted, string[] inputTopDirs, string[] scenePaths, string resRootPath)
        {
            CommonHelper.PathCreate(workPath);
            AssetDatabase.Refresh();
            CreateAssetConfig.Build();
            if (AssetBundleConfigQueue.Count <= 0)
                LoadAssetBundles();
            var abs = GetAssetBundleBuild();
            BuildAssetBundleOptions options = BuildAssetBundleOptions.DeterministicAssetBundle | BuildAssetBundleOptions.UncompressedAssetBundle;
            BuildPipeline.BuildAssetBundles(workPath, abs, options, target);
        }

        //wx2 park
        private static void WX2PARK(string workPath, BuildTarget target, bool encrypted, string[] inputTopDirs, string[] scenePaths, string resRootPath)
        {
            artConfig = new ArtPathConfig();
            artConfig.Load();
            List<string> configPath = new List<string>();
            foreach (var path in artConfig.ArtPath)
            {
                Debug.Log("从配置中获取的目录 = " + path);
                var resDir = CommonHelper.PathCombine(Application.dataPath, path);
                configPath.Add(resDir);
                //检查下获取的路径是否存在
                if (!Directory.Exists(resDir))
                {
                    Debug.LogError("res path not exists : " + resDir);
                    return;
                }
                //在Assets下拿ResPath  Assets/Game/Res
                //GetAssetInFolder(resDir);
            }

            //默认其实是true 
            bool bExportAll = (inputTopDirs == null && scenePaths == null);


            //获取要打包成AB的目录
            //顶层文件夹
            if (inputTopDirs == null)
            {
                // inputTopDirs = new string[] { CommonHelper.PathCombine(Application.dataPath, "/Art") };
                inputTopDirs = configPath.ToArray();
            }

            Debug.Log("获取子文件夹");
            //获取子文件夹
            List<DirectoryInfo> inputSubDirs = new List<DirectoryInfo>();
            for (int i = 0; i < inputTopDirs.Length; i++)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(inputTopDirs[i]);
                Debug.Log("子文件夹 dir = " + dirInfo);
                inputSubDirs.Add(dirInfo);
            }

            //要打包的文件
            List<FileInfo> inputFiles = new List<FileInfo>();

            //从输入目录和输入场景文件中获取将要生成的AB名称
            List<string> resPaths = new List<string>();
            //递归所有子文件夹 获取全部输入路径
            for (int i = 0; i < inputSubDirs.Count; i++)
            {
                GetResInputPath(inputSubDirs[i], resPaths);
            }

            //将来场景打包后加进去
            //for (int i = 0; i < inputFiles.Count; i++)
            //{
            //    resPaths.Add(inputFiles[i].FullName);
            //}

            //如果打包全部资源，删除无效的AB
            if (bExportAll)
            {
                //删除上次存在这次不生成的AB
                // DeleteInvalidRes(target, encrypted, resPaths, resRootPath);
            }

            ExportRes(target, inputSubDirs.ToArray(), inputFiles.ToArray(), resRootPath);
        }

        #region PEPARK
        //-----------------------------------------------PEPARK--------------------------------------------------
        static AssetBundleBuild[] GetAssetBundleBuild()
        {
            var dataPath = Path.GetFullPath(".");
            dataPath = dataPath.Replace("\\", "/");

            List<AssetBundleBuild> abs = new List<AssetBundleBuild>();
            foreach (var it in AssetBundleConfigQueue)
            {
                AssetBundleBuild ab = new AssetBundleBuild();
                ab.assetBundleName = it.Name;
                ab.assetBundleVariant = "";
                ab.assetNames = it.Assets.ToArray();
                abs.Add(ab);
            }
            return abs.ToArray();
        }
        // 读ab配置
        static bool LoadAssetBundles()
        {
            string cfgPath = CommonHelper.PathCombine(workPath, "abc.yaml");

            AssetBundleConfigQueue.Clear();
            ResPathAssetBundleConfigQueue.Clear();

            List<AssetBundleSerializer> abc = new List<AssetBundleSerializer>();

            var reader = File.OpenText(cfgPath);
            var deserializer = new Deserializer();
            AssetBundleConfigQueue = deserializer.Deserialize<List<AssetBundleSerializer>>(reader);
            reader.Close();

            for (int i = 0; i < AssetBundleConfigQueue.Count; i++)
            {
                for (int j = 0; j < AssetBundleConfigQueue[i].Assets.Count; j++)
                {
                    ResPathAssetBundleConfigQueue[AssetBundleConfigQueue[i].Assets[j]] = AssetBundleConfigQueue[i].Name;
                }
            }
            return true;
        }
        //---------------------------------------------------PEPARK------------------------------------------------------------------
        #endregion


        #region WX2PARK
        //---------------------------------------------------WX2PARK------------------------------------------------------------------

        private static void GetResInputPath(DirectoryInfo dirInfo, List<string> paths)
        {
            DirectoryInfo[] subFolders = dirInfo.GetDirectories();
            for (int i = 0; i < subFolders.Length; i++)
            {
                GetResInputPath(subFolders[i], paths);
            }

        }

        private static void RecGetRecAssetBundleBuilds(DirectoryInfo dirInfo, List<AssetBundleBuild> builds)
        {
            //获取该文件内所有资源
            List<string> fileNames = new List<string>();
            FileInfo[] files = dirInfo.GetFiles();
            for (int i = 0; i < files.Length; i++)
            {
                
                //剔除一些后缀文件
                if (CommonHelper.IsEndWith(FILE_EXCLUDE_PATTERNS, files[i].Name))
                    continue;

                //获取文件系统路径 带后缀
                string fullName = CommonHelper.StandardizePath(files[i].FullName);
                Debug.Log("子文件夹 真正的 = " + fullName.Substring(fullName.IndexOf("Assets" + CommonHelper.separatorChar)));
                //从Assets截取
                fileNames.Add(fullName.Substring(fullName.IndexOf("Assets"+CommonHelper.separatorChar)));
            }

            //获取build信息
            if (fileNames.Count > 0)
            {
                AssetBundleBuild build = new AssetBundleBuild();
                build.assetBundleName = ResPackHelper.GetResPackageName(dirInfo.FullName, false) + BuildLuaAB.PLAIN_EXT;
                build.assetNames = fileNames.ToArray();
                builds.Add(build);
            }

            //递归子文件夹
            DirectoryInfo[] subFolders = dirInfo.GetDirectories();
            for (int i = 0; i < subFolders.Length; i++)
            {
                RecGetRecAssetBundleBuilds(subFolders[i], builds);
            }
        }

        //打包指定文件夹中的资源
        public static void ExportRes(BuildTarget target, DirectoryInfo[] dirs, FileInfo[] files, string resRootPath)
        {
            //如果输出目录不存在，先创建
            //string assetBundleOutputPath = 

            List<AssetBundleBuild> builds = new List<AssetBundleBuild>();
            // 递归所有子文件夹 获取全部 AssetBundleBuild 信息
            if (dirs != null)
            {
                for (int i = 0; i < dirs.Length; i++)
                {
                    RecGetRecAssetBundleBuilds(dirs[i],builds);
                }
            }

            //获取文件的AssetBundleBuild信息
            if (files != null)
            {
                for (int i = 0; i < files.Length; i++)
                {
                    AssetBundleBuild build = new AssetBundleBuild();
                    string fullName = CommonHelper.StandardizePath(files[i].FullName);
                    build.assetBundleName = ResPackHelper.GetResPackageName(fullName,false) + BuildLuaAB.PLAIN_EXT;
                    Debug.Log("bundleName = "+ build.assetBundleName);
                    //截取到Assets
                    build.assetNames = new string[] { fullName.Substring(fullName.IndexOf("Assets" + CommonHelper.separatorChar)) };
                    builds.Add(build);
                }
            }
            //创建AssetBundles
            if (builds.Count > 0)
            {
                CommonHelper.PathCreate(workPath);
                var buildManifest = BuildPipeline.BuildAssetBundles(workPath, builds.ToArray(), BuildAssetBundleOptions.DeterministicAssetBundle, target);
                if (buildManifest == null)
                {
                    Debug.LogError("Error in build");
                }
                Debug.Log("assetbundle资源打包完成。");
            }
        }

        /// <summary>
        /// 删除无效的AB
        /// </summary>
        /// <param name="target"></param>
        /// <param name="encrypted"></param>
        /// <param name="newResourcePaths"></param>
        /// <param name="resRootPath"></param>
        private static void DeleteInvalidRes(BuildTarget target,bool encrypted, List<string> newResourcePaths, string resRootPath)
        {
            //记录将要生成的AB
            Dictionary<string, bool> filesWillExport = new Dictionary<string, bool>();
            for (int i = 0; i < newResourcePaths.Count; i++)
            {
                string resPackageName = ResPackHelper.GetResPackageName(newResourcePaths[i],false);
                string fileName = CommonHelper.GetFileName(resPackageName, false);
                filesWillExport.Add(fileName,true);
            }

            //获取当前输出目录中除了lua的AB
           // List<FileInfo> allPackeages = GetResPackages(target,encrypted, ResPackHelper.ResType.Res, resRootPath); 
        }

        //private static List<FileInfo> GetResPackages(BuildTarget target, bool encrypted, ResPackHelper.ResType resourceType, string resRootPath)
        //{

        //}
        #endregion
    }

}
