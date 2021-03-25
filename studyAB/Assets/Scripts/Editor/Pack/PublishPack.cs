using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEditor;
using UnityEditor.Build;
namespace StarStudio
{
    public class PublishPack
    {
        public enum PackType
        {
            All = 0,
            Essential,
            App,
        }

        //设置预定义标签
        private static void SetPlayerSetting(BuildTarget target)
        {
            BuildTargetGroup targetGroup = BuildTargetGroup.Standalone;
            string defineSymbols = PlayerSettings.GetScriptingDefineSymbolsForGroup(targetGroup);
        }

        public static void BuildProject(string publishPath,BuildTarget target, bool encrypted, bool isDebug, bool allResPacked, PackType packType)
        {
            bool successful = true;

            try
            {
                //设置标签
                //SetPlayerSetting(target);

                BuildOptions buildOptions = BuildOptions.None;
                string extName = null;
                switch (target)
                {
                    case BuildTarget.StandaloneWindows:
                    case BuildTarget.StandaloneWindows64:
                        extName = ".exe";
                        break;
                    case BuildTarget.Android:
                        buildOptions |= BuildOptions.AcceptExternalModificationsToPlayer;
                        break;
                    default:
                        break;
                }

                if (isDebug)
                {
                    buildOptions |= BuildOptions.Development;
                    buildOptions |= BuildOptions.ConnectWithProfiler;
                    buildOptions |= BuildOptions.AllowDebugging;
                }

                List<string> scenePath = new List<string>();
                EditorBuildSettingsScene[] activeScenes = EditorBuildSettings.scenes;
                if (extName != null || target == BuildTarget.iOS || target == BuildTarget.Android)
                {
                    //获取场景
                    for (int i = 0; i < activeScenes.Length; i++)
                    {
                        scenePath.Add(activeScenes[i].path);
                    }
                }

                try
                {
                    string buildPath = "";
                    if (target == BuildTarget.Android)
                        buildPath = publishPath;
                    else
                        buildPath = CommonHelper.PathCombine(publishPath,string.Format("pubpublishPathlish{0}",extName));

                    BuildTargetGroup buildTargetGroup = BuildPipeline.GetBuildTargetGroup(target);

                    //切换平台
                    bool switched = EditorUserBuildSettings.SwitchActiveBuildTarget(buildTargetGroup,target);
                    if (switched)
                    {
                        buildPath = Path.GetFullPath(buildPath);
                        var error = BuildPipeline.BuildPlayer(scenePath.ToArray(),buildPath,target,buildOptions);
                        //if (string.IsNullOrEmpty(error.ToString()))
                        //{

                        //}
                    }
                }
                catch (Exception ex)
                {
                    successful = false;
                }
            }
            catch (Exception ex)
            {
                successful = false;   
            }
        }
    }
}

