using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class BuildAPK 
{

   // string TargetAndroidPath { get { return Application.dataPath.Replace("Assets", "ForEclipse"); } }
    [MenuItem("Tool/BuildAPK")]
    public static void Build()
    {

        BuildApk();

    }

    static string TargetAndroidPath { get { return Application.dataPath.Replace("Assets", "ForEclipse"); } }
    public static void BuildApk()
    {

        BuildPipeline.BuildPlayer(getActiveScene(), TargetAndroidPath, BuildTarget.Android, BuildOptions.None);
    }

    static string[] getActiveScene()
    {
        var activeScenes = EditorBuildSettings.scenes;
        List<string> getScenesStr = new List<string>();
        for (int i = 0; i < activeScenes.Length; i++)
        {
            if (activeScenes[i].enabled)
                getScenesStr.Add(activeScenes[i].path);
        }
        return getScenesStr.ToArray();
    }
}
