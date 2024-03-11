using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text.RegularExpressions;
public class ChangeImgName : MonoBehaviour
{

    public string folderPath = "Assets/Main/Scenes/SeasonEdenZone/S7/Images/";
    // Start is called before the first frame update
    void Start()
    {
        string[] textures = Directory.GetFiles("Assets/Main/Scenes/SeasonEdenZone/S7/Image/", "*.png");
        int value = 0;
        // 遍历每个文件并修改文件名
        foreach (string filePath in textures)
        {
            // 获取文件名和扩展名
            string fileName = Path.GetFileNameWithoutExtension(filePath);
            string fileExtension = Path.GetExtension(filePath);

            Match match = Regex.Match(fileName, @"(\d+)$");
            
            if (match.Success)
            {
                // 获取数字后缀
                string numericSuffix = match.Groups[1].Value;

                value = int.Parse(numericSuffix);

                var change = value + 400;
                
                // 修改文件名
                string newFileName = fileName.Replace(numericSuffix, change.ToString());

                // 构建新的文件路径
                string newFilePath = Path.Combine(folderPath, newFileName + fileExtension);

                // 重命名文件
                File.Move(filePath, newFilePath);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
