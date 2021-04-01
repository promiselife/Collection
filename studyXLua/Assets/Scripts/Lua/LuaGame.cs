using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace StarStudio
{
    public class LuaGame : InstanceBehaviour<LuaGame>
    {
        
        class LuaText
        {
            public string luaPath;
            public byte[] text;
            public float time;
        }

        static LuaEnv luaEnv;
       
        internal static float lastGCTime = 0;
        internal const float GCInterval = 1;

        static bool canDispose = false;

        [CSharpCallLua]
        public delegate void LuaUpdate(float t1, float t2);
        [CSharpCallLua]
        public delegate void LuaLateUpdate();

        private LuaUpdate _LuaUpdate;
        private LuaLateUpdate _LuaLateUpdate;


    }
}

