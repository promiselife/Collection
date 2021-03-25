using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System;

namespace StarStudio
{
    public class BuildLuaAB
    {

        //AssetsBundle文件输出拓展名
        public const string PLAIN_EXT = ".assets";

        private const string TMP_PATH = "Tmp";

        public static string workPath = Application.streamingAssetsPath + "/AssetBundle";

        public static bool BuildAssetsAB(BuildTarget target)
        {
            //检查输出路径
            CommonHelper.PathCreate(workPath);
            //BuildPipeline.BuildAssetBundles(workPath,BuildAssetBundleOptions.None,BuildTarget.StandaloneWindows);
            var buildManifest = BuildPipeline.BuildAssetBundles(workPath, BuildAssetBundleOptions.None, target);
            AssetDatabase.Refresh();
            if (buildManifest == null)
            {
                Debug.LogError("Error in build");
                return false;
            }
            Debug.Log("assetbundle资源打包完成。");
            return true;
        }


        public static void BuildLua(BuildTarget target)
        {
            
            //设置LuaBundle名
            string assetBundleName = "lua" + PLAIN_EXT;

            //查找lua文件是否存在  现在默认为在Assets目录下有个Lua文件夹
            string luaPath = CommonHelper.PathCombine(Application.dataPath,"Lua");
            if (!CommonHelper.PathIsExist(luaPath))
            {
                Debug.LogError("lua paht not found");
                return;
            }

            //设置临时目标保存lua.bytes
            string pakTmpPath = CommonHelper.PathCombine(TMP_PATH, "Lua");
            string tmpPath = CommonHelper.PathCombine(Application.dataPath, pakTmpPath);
            CommonHelper.CheckDir(tmpPath);

            //拿到所有lua脚本
            List<string> files = CommonHelper.GetAllFiles(luaPath);

            string filename = "";
            string tmpFilePath = "";
            List<string> exports = new List<string>();
            //将".lua"转换为".bytes"
            for (int i = 0; i < files.Count; i++)
            {
                filename = files[i].Substring(1, files[i].Length - 1).Replace(".lua", ".bytes").Replace('\\', '_').Replace(CommonHelper.separatorChar, '_');
                if (filename.StartsWith("lib_"))
                {
                    filename = filename.Substring(4, filename.Length - 4);
                    
                }
                tmpFilePath = CommonHelper.PathCombine(tmpPath,filename);
                exports.Add(string.Format("Assets/{0}/{1}", pakTmpPath, filename));
                //tmpname = string.Format("Assets/Lua/{0}", filename);
                //exports.Add(string.Format("\"{0}\"", tmpname));

                //".bytes"文件拷贝到临时目录
                File.Copy(luaPath + files[i], tmpFilePath, true);
            }

            System.Threading.Thread.Sleep(1000);
            AssetDatabase.Refresh();

            //检查输出路径
            CommonHelper.PathCreate(workPath);

            AssetBundleBuild[] abBuilder = new AssetBundleBuild[1];
            abBuilder[0].assetBundleName = assetBundleName;
            abBuilder[0].assetNames = exports.ToArray();

            var buildManifest =  BuildPipeline.BuildAssetBundles(workPath, abBuilder, BuildAssetBundleOptions.None, target);
            if (buildManifest == null)
            {
                Debug.LogError("Error in build Lua");
            }
            Debug.Log(string.Format("Lua {0} 打包完成，文件路径--> {1}", target,workPath));

            // 清理以下冗余文件
            string[] subPathsToDelete = { "Lua", "Lua.manifest", /*"lua.assets.manifest"*/ };
            for (int i = 0; i < subPathsToDelete.Length; i++)
            {
                string subPath = subPathsToDelete[i];
                File.Delete(CommonHelper.PathCombine(workPath, subPath));
                File.Delete(CommonHelper.PathCombine(workPath, subPath + ".meta"));
            }
        }

    }

}
