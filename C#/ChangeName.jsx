#target photoshop

// Created by zhangliheng.
// DateTime: 2022/10/21 16:12
// 导出psd中所有layer的坐标信息

app.bringToFront()

main()

function main() 
{


    var docRef = activeDocument
    var layers = docRef.layers


    var jsonChildrenStr = ""
    for(var i = 0; i< layers.length; i++)
    {
        var layer = layers[i]

        var match = layer.name.match(/_(\d+)$/);

          if (match) {
            // 获取匹配的数字后缀
            var numericSuffix = match[1];

            if(parseInt(numericSuffix) > 840){
                var value = parseInt(numericSuffix) - 1

                // 修改图层名逻辑（在这里可以根据需要定义）
                layer.name = "zone_" + value;
            }
        }

    }

    alert("Done!")
}
