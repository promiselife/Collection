using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
namespace StarStudio
{
    public class EditorUnify
    {

        [MenuItem("AssetBundleTools/BuilAsset/Android/打出文件配置资源")]
        public static void PackAssetsFolderAndroid()
        {
            //BuildAB.BuildAssetsAB(BuildTarget.Android);
            ExportAsset.ExportRes(0,BuildTarget.Android, false, null, null,null);
        }

        [MenuItem("AssetBundleTools/BuilAsset/Android/打出每一个配置资源")]
        public static void PackAssetsAllAndroid()
        {
            //BuildAB.BuildAssetsAB(BuildTarget.Android);
            ExportAsset.ExportRes(1,BuildTarget.Android, false, null, null, null);
        }

        [MenuItem("AssetBundleTools/BuilAsset/IOS/打出文件配置资源")]
        public static void PackAssetsFolderIOS()
        {
            //BuildAB.BuildAssetsAB(BuildTarget.Android);
            ExportAsset.ExportRes(0,BuildTarget.iOS, false, null, null, null);
        }

        [MenuItem("AssetBundleTools/BuilAsset/IOS/打出每一个配置资源")]
        public static void PackAssetsAllIOS()
        {
            //BuildAB.BuildAssetsAB(BuildTarget.Android);
            ExportAsset.ExportRes(1,BuildTarget.iOS, false, null, null, null);
        }

        [MenuItem("AssetBundleTools/Lua/Android")]
        public void PackLuaAndroid()
        {
            BuildLuaAB.BuildLua(BuildTarget.Android);
        }

        [MenuItem("AssetBundleTools/Lua/IOS")]
        public void PackLuaIOS()
        {
            BuildLuaAB.BuildLua(BuildTarget.iOS);
        }
    }
}

