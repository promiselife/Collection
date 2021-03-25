using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StarStudio
{
    public class AssetsBundleLoad
    {
        public static string workPath = Application.streamingAssetsPath + "/AssetBundle";

        // Start is called before the first frame update
        void Start()
        {
            AssetBundle ab =  AssetBundle.LoadFromFile(workPath+ "/Android/art_prefab_ui_bag.assets");

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}


