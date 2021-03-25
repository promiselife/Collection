using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using YamlDotNet.Serialization;

namespace StarStudio
{

    /// <summary>
    /// 获取美术资源目录
    /// </summary>
    public class ArtPathConfig
    {
        public List<string> ArtPath = new List<string>();

        public bool Load()
        {
            string config = CommonHelper.PathCombine(Application.dataPath, "Config/ArtPath.txt");
            if (!File.Exists(config))
            {
                Debug.Log("can't find config file --> " + config);
                return false;
            }
            using (var sr = new StreamReader(config))
            {
                var line = sr.ReadLine();
                do
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        line = line.Trim();
                        if (!string.IsNullOrEmpty(line))
                        {
                            ArtPath.Add(line);
                        }
                    }
                    line = sr.ReadLine();
                }
                while (line != null);
            }
            if (ArtPath.Count <= 0)
            {
                Debug.Log("ArtPath config is Empty");
                return false;
            }
            return true;
        }
    }

    public class IgnoreFileConfig
    {
        public List<string> IgnoreList = new List<string>();
        public Dictionary<string, bool> matchCahche = new Dictionary<string, bool>();

        public bool Load()
        {
            matchCahche.Clear();
            string confg = CommonHelper.PathCombine(Application.dataPath, "Config/IgnoreFile.txt");
            if (!File.Exists(confg))
            {
                Debug.LogError("Can't find config file: " + confg);
                return false;
            }

            using (var sr = new StreamReader(confg))
            {
                var line = sr.ReadLine();
                do
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        line = line.Trim().ToLower();
                        if (!string.IsNullOrEmpty(line))
                            IgnoreList.Add(line);
                    }
                    line = sr.ReadLine();
                } while (line != null);
            }
            return true;
        }

        public bool IsMatch(string fileName)
        {
            bool isMatch = false;
            if (matchCahche.TryGetValue(fileName, out isMatch))
            {
                return isMatch;
            }

            foreach (var regex in IgnoreList)
            {
                //                var matches = Regex.IsMatch(fileName, regex, RegexOptions.IgnoreCase);
                var matches = fileName.ToLower().EndsWith(regex);
                if (matches)
                {
                    matchCahche.Add(fileName, true);
                    return true;
                }
            }
            matchCahche.Add(fileName, false);
            return false;
        }
    }
    public class AssetBundleSerializer
    {
        [YamlMember(Alias = "name", ApplyNamingConventions = false)]
        public string Name { get; set; }
        [YamlMember(Alias = "assets", ApplyNamingConventions = false)]
        public List<string> Assets { get; set; } = new List<string>();
        [YamlMember(Alias = "dependencies", ApplyNamingConventions = false)]
        public List<string> Dependencies { get; set; } = new List<string>();

        public void AddDependence(string ab)
        {
            if (ab != Name && Dependencies.FindIndex(x => { return x == ab; }) < 0)
            {
                Dependencies.Add(ab);
            }
        }
    }

    public class CreateAssetConfig
    {
        private static ArtPathConfig artConfig = null;
        private static IgnoreFileConfig ignoreConfig = null;

        private static List<string> resFileList = new List<string>();
        private static Dictionary<string, ResNode> resNodeDic = new Dictionary<string, ResNode>();
        private static List<ResNode> resNodeTree = new List<ResNode>();

        class ResNode
        {
            public string assetsPath;
            public HashSet<ResNode> nexts = new HashSet<ResNode>();
            public HashSet<ResNode> previous = new HashSet<ResNode>();

            public int refCount { get { return previous.Count; } }
            private bool isRes = false;
            public bool IsRes { get { return isRes; } set { isRes = value; ResetAssetsBundleName(); } }
            public string AssetsBundleName = "";
            public bool IsScene() { return assetsPath.ToLower().EndsWith(".unity"); }
            public bool IsPrefab() { return assetsPath.ToLower().EndsWith(".prefab"); }
            public bool SearchLoop(ResNode target)
            {
                foreach (var node in nexts)
                {
                    if (node == target)
                        return true;
                    return node.SearchLoop(target);
                }
                return false;
            }
            public void AddNextNode(ResNode node)
            {
                if (node != null)
                {
                    nexts.Add(node);
                    ResetAssetsBundleName();
                }
            }
            public void AddPreviousNode(ResNode node)
            {
                if (node != null)
                {
                    previous.Add(node);
                    ResetAssetsBundleName();
                }
            }

            public string ResetAssetsBundleName()
            {
                AssetsBundleName = "";

                if (IsRes)
                {
                    if (IsScene())
                    {
                        var name = assetsPath.Replace(".", "_") + ".sc";
                        AssetsBundleName = name.ToLower();
                    }
                    else
                    {
                        var name = assetsPath.Replace(".", "_") + ".ab";
                        AssetsBundleName = name.ToLower();
                    }
                    return AssetsBundleName;
                }

                if (previous.Count > 1)
                {
                    var name = assetsPath.Replace(".", "_") + ".ab";
                    AssetsBundleName = name.ToLower();
                }
                else if (previous.Count == 1 && IsPrefab())
                {
                    using (var it = previous.GetEnumerator())
                    {
                        it.MoveNext();
                        if (it.Current != null && it.Current.IsScene())
                        {
                            var name = assetsPath.Replace(".", "_") + ".ab";
                            AssetsBundleName = name.ToLower();
                        }
                    }
                }
                return AssetsBundleName;
            }
            public void GetDependenciesAssetBundleAll(ResNode root, List<ResNode> dependencies)
            {
                foreach (var node in nexts)
                {
                    if (node == root)
                        continue;

                    if (!string.IsNullOrEmpty(node.AssetsBundleName) && dependencies.FindIndex(x => { return node == x; }) < 0)
                    {
                        dependencies.Add(node);
                    }
                }

                foreach (var node in nexts)
                {
                    if (node == root)
                        continue;

                    node.GetDependenciesAssetBundleAll(root, dependencies);
                }
            }
        }


        //PE park build
        public static void Build()
        {
            string confPath = CommonHelper.PathCombine(ExportAsset.workPath, "abc.yaml");
            Debug.Log(ExportAsset.workPath);

            //加载资源目录
            artConfig = new ArtPathConfig();
            if (!artConfig.Load())
            {
                return;
            }
            //加载特殊后缀目录
            ignoreConfig = new IgnoreFileConfig();
            if (!ignoreConfig.Load())
            {
                return;
            }

            resFileList.Clear();
            foreach (var path in artConfig.ArtPath)
            {
                var resDir = CommonHelper.PathCombine(Application.dataPath, path);
                if (!Directory.Exists(resDir))
                {
                    Debug.LogError("res path not exists : " + resDir);
                    return;
                }
                //遍历所有目录及具体资源并剔除特殊后缀资源
                GetAssetInFolder(resDir);
            }

            foreach (var scene in EditorBuildSettings.scenes)
            {
                //if (scene.path.EndsWith("loading.unity"))
                //    continue;
                resFileList.Add(scene.path);
            }

            //分析资源依赖关系
            resNodeDic.Clear();
            DirectedGraphs2Tree();

            Dictionary<string, AssetBundleSerializer> abc = new Dictionary<string, AssetBundleSerializer>();
            foreach (var node in resNodeDic)
            {
                var assetsAB = node.Value;
                if (!string.IsNullOrEmpty(assetsAB.AssetsBundleName))
                {
                    AssetBundleSerializer ab = null;
                    if (!abc.TryGetValue(assetsAB.AssetsBundleName, out ab))
                    {
                        ab = new AssetBundleSerializer();
                        ab.Name = assetsAB.AssetsBundleName;
                        abc[assetsAB.AssetsBundleName] = ab;
                    }
                    ab.Assets.Add(assetsAB.assetsPath);
                    List<ResNode> dependencies = new List<ResNode>();
                    assetsAB.GetDependenciesAssetBundleAll(assetsAB, dependencies);
                    for (int i = 0; i < dependencies.Count; i++)
                    {
                        ab.AddDependence(dependencies[i].AssetsBundleName);
                    }
                }
            }

           // AssetDatabase.Refresh();
            //生成文件
            using (var writer = File.CreateText(confPath))
            {
                var serializer = new Serializer();
                var list = abc.Values.ToList();
                list.Sort((x, y) =>
                {
                    return x.Name.CompareTo(y.Name);
                });
                serializer.Serialize(writer, list);
            }
        }

        // Dependency "Tree0"         = "Hidden/TerrainEngine/BillboardTree"
        // Fallback "Diffuse"
        private static readonly string[] ShaderDepedencyPatterns =
        {
            @"Dependency\s+"".*\""\s+=\s+""(.*)""",
            @"Fallback\s+""(.*)""",
        };

        private static void GetShaderDependencies(string pathName, List<string> result, bool recursive = true)
        {
            var text = File.ReadAllText(pathName);
            for (int i = 0; i < ShaderDepedencyPatterns.Length; i++)
            {
                var matches = Regex.Matches(text, ShaderDepedencyPatterns[i], RegexOptions.Multiline);
                for (int j = 0; j < matches.Count; j++)
                {
                    if (!matches[j].Success)
                    {
                        continue;
                    }

                    string shaderName = matches[j].Groups[1].Value;
                    if (result.Contains(shaderName))
                    {
                        continue;
                    }

                    var shader = Shader.Find(shaderName);
                    if (shader == null)
                    {
                        continue;
                    }

                    string shaderPath = AssetDatabase.GetAssetPath(shader);
                    result.Add(shaderPath);

                    if (recursive)
                    {
                        GetShaderDependencies(shaderPath, result, true);
                    }
                }
            }
        }

        static void GetAssetInFolder(string path)
        {
            path = path.Replace("\\", "/");
            if (!path.EndsWith("/"))
                path += "/";

            var dir = Directory.CreateDirectory(path);
            if (dir.Exists)
            {
                var files = dir.GetFiles();
                for (int i = 0; i < files.Length; i++)
                {
                    var filePath = files[i].FullName;
                    //剔除特殊后缀文件
                    if (ignoreConfig.IsMatch(filePath))
                        continue;
                    filePath = filePath.Replace(Path.GetFullPath(".") + "\\", "");
                    resFileList.Add(filePath);
                }

                var subDirs = dir.GetDirectories();
                for (int i = 0; i < subDirs.Length; i++)
                {
                    GetAssetInFolder(subDirs[i].FullName);
                }
            }
        }

        // 有向图->树
        static void DirectedGraphs2Tree()
        {
            //分析资源文件
            for (int i = 0; i < resFileList.Count; i++)
            {
                var assetsPath = resFileList[i].Replace("\\", "/");

                var tree = GenTree(assetsPath);
                resNodeTree.Add(tree);
            }
        }
        // 生成依赖树
        static ResNode GenTree(string assetsPath)
        {
            ResNode node = null;
            if (!resNodeDic.TryGetValue(assetsPath, out node))
            {
                node = new ResNode();
                node.assetsPath = assetsPath;
                node.ResetAssetsBundleName();
                resNodeDic[assetsPath] = node;

                node.IsRes = true;
                SearchDependencies(node);
            }
            node.IsRes = true;
            node.ResetAssetsBundleName();
            return node;
        }
        // 搜索
        static void SearchDependencies(ResNode root)
        {
            if (root == null)
                return;
            //Debug.Log("输入依赖目录 = "+root.assetsPath);
            var list = GetDependencies(root.assetsPath);
            if (list == null || list.Length <= 0)
            {
                return;
            }
            List<ResNode> newNode = new List<ResNode>();
            foreach (var assetsPath in list)
            {
                if (ignoreConfig.IsMatch(assetsPath))
                    continue;
                if (root.assetsPath.Contains("Art/Prefab/UI") && assetsPath.Contains("Art/Prefab/UI"))
                    continue;

                bool isNew = false;
                ResNode node = null;
                if (!resNodeDic.TryGetValue(assetsPath, out node))
                {
                    isNew = true;
                    node = new ResNode();
                    node.assetsPath = assetsPath;
                    node.ResetAssetsBundleName();
                    resNodeDic[assetsPath] = node;
                    newNode.Add(node);
                }

                if (!isNew)
                {
                    // 已有节点需要考虑环形依赖
                    node.AddPreviousNode(root);
                    root.AddNextNode(node);
                }
                else
                {
                    // 新发现的节点
                    node.AddPreviousNode(root);
                    root.AddNextNode(node);
                }
            }

            // 递归搜索新节点
            foreach (var node in newNode)
            {
                SearchDependencies(node);
            }
        }
        // 获取资源依赖
        private static string[] GetDependencies(string pathName)
        {
            //Debug.Log("获取资源依赖的路径 = "+ pathName);
            var pathNameLower = pathName.ToLower();
            if (pathNameLower.EndsWith(".txt")
                || pathNameLower.EndsWith(".xml")
                || pathNameLower.EndsWith(".png")
                || pathNameLower.EndsWith(".tga")
                || pathNameLower.EndsWith(".anim")
                )
            {
                return null;
            }
            if (pathNameLower.EndsWith(".shader"))
            {
                var result = new List<string>();
                GetShaderDependencies(pathName, result);
                return result.ToArray();
            }
            return AssetDatabase.GetDependencies(pathName, false);
        }
    }
}

