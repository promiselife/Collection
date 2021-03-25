using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.IO;

using System.Text;
namespace StarStudio
{
    public class CommonHelper
    {
        public const char separatorChar = '/';

        //路径合并
        public static string PathCombine(params string[] strs)
        {

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < strs.Length; i++)
            {
                sb.Append(strs[i]);

                if (i != strs.Length - 1 && sb[sb.Length - 1] != CommonHelper.separatorChar)
                    sb.Append(CommonHelper.separatorChar);
            }
            return sb.ToString();

        }


        #region file path
        /// <summary>
        /// 判断文件夹是否存在
        /// </summary>
        /// <param name="path">EditorPath</param>
        /// <returns>bool</returns>
        public static bool PathIsExist(string path)
        {
            if (!Directory.Exists(path))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 路径不存在时创建
        /// </summary>
        /// <param name="outpath">EditorPath</param>
        public static void PathCreate(string outpath)
        {
            if (!Directory.Exists(outpath))
                Directory.CreateDirectory(outpath);
        }

        /// <summary>
        /// 获取所有lua文件
        /// </summary>
        /// <param name="path">lua文件总目录</param>
        /// <param name="match">后缀</param>
        /// <returns></returns>
        public static List<string> GetAllFiles(string path,string match = ".lua")
        {
            DirectoryInfo dirPath = new DirectoryInfo(path);
            return GetAllFiles(dirPath,match);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dirPath"></param>
        /// <param name="match"></param>
        /// <param name="sub"></param>
        /// <returns></returns>
        private static List<string> GetAllFiles(DirectoryInfo dirPath,string match = ".lua",string sub = "")
        {
            List<string> results = new List<string>();

            FileInfo[] files = dirPath.GetFiles();
            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].Name.EndsWith(match))
                {
                    Debug.Log(files[i].Name);
                    results.Add(sub + CommonHelper.separatorChar + files[i].Name);
                }
            }

            //DirectoryInfo[] dirs = dirPath.GetDirectories();
            //for (int i = 0; i < dirs.Length; i++)
            //{
               // Debug.Log(dirs[i].Name);
               // results.AddRange(GetAllFiles(dirs[i],match,sub + CommonHelper.separatorChar + dirs[i].Name));
            //}
            return results;
        }

        /// <summary>
        ///将编辑器路径转换为系统路径
        /// </summary>
        /// <param name="path">编辑器路径</param>
        /// <returns>a/b/c ---> "a\b\c"</returns>
        public static String PathChangeSystem(string path)
        {
            return string.Format("\"{0}\"", path).Replace('/', '\\');
        }

        public static void CheckDir(string path, bool rewrite = true)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            bool exists = dirInfo.Exists;
            if (exists && rewrite)
            {
                dirInfo.Delete(true);
                exists = false;
            }

            if (!exists)
            {
                Directory.CreateDirectory(path);
            }
        }

        public static string StandardizePath(string path)
        {
            path = path.Replace('\\', separatorChar);

            return path;
        }

        //字符串后缀测试
        public static bool IsEndWith(string[] values, string value)
        {
            for (int i = 0; i < values.Length; i++)
                if (value.EndsWith(values[i]))
                    return true;

            return false;
        }

        public static string GetFileName(string filePath, bool includeExt)
        {
            filePath = StandardizePath(filePath);

            string fileName = filePath;

            int lastSlashIndex = filePath.LastIndexOf("/");
            if (lastSlashIndex >= 0)
            {
                if (lastSlashIndex < fileName.Length - 1)
                {
                    fileName = fileName.Substring(lastSlashIndex + 1);
                }
                else
                {
                    fileName = "";
                }
            }

            if (!includeExt)
            {
                int lastDotIndex = fileName.LastIndexOf(".");
                if (lastDotIndex >= 0)
                {
                    if (lastDotIndex < fileName.Length - 1)
                    {
                        fileName = fileName.Substring(0, lastDotIndex);
                    }
                    else
                    {
                        fileName = "";
                    }
                }
            }

            return fileName;
        }


        #endregion
    }

    public class ResPackHelper
    {
        public enum ResType
        {
            All = 0,
            Lua,
            Res,
        }
        public const char SLASH_REPLACER = '_'; // "/"的替代字符

        public static string GetResPackageName(string fullName, bool includeExt)
        {
            fullName = CommonHelper.StandardizePath(fullName);

            if (!includeExt)
            {
                string ext = Path.GetExtension(fullName);
                if (!string.IsNullOrEmpty(ext))
                {
                    fullName = fullName.Replace(ext, "");
                }
            }

            char systemSlash = CommonHelper.separatorChar;
            string folderPath = "Assets";
            //截取路径 并替换/ 为_作为AssetBundle的文件名
            string assetBundleName = fullName.Split(new string[] { folderPath + systemSlash }, System.StringSplitOptions.RemoveEmptyEntries)[1];
            return assetBundleName.Replace(systemSlash, SLASH_REPLACER).ToLower();
        }

        //public static string GetResTargetDir(BuildTarget target, string resRootPath = null)
        //{
            //string resTargetPath = null;

            //if (string.IsNullOrEmpty(resRootPath))
            //{
            //    resTargetPath = GetOutputPath(target);
            //}
            //else
            //{
            //    resTargetPath = CommonHelper.StandardizePath(CommonHelper.PathCombine(resRootPath, ResourceHelper.GetPlatformFolderName(ResPackHelper.GetRuntimePlatform(target))));
            //}

            //return resTargetPath;
        //}
        //public static string GetResroucesOutputDir(BuildTarget target, ResType resourceType, string resRootPath = null)
        //{
        //    string resTargetPath = GetResTargetDir(target, resRootPath);
        //    if (resourceType == ResType.Lua)
        //    {
        //        return CommonHelper.PathCombine(resTargetPath, "Lua");
        //    }
        //    else
        //    {
        //        return CommonHelper.PathCombine(resTargetPath, "Resources");
        //    }
        //}
    }

}