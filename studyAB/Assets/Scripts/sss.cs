using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sss : MonoBehaviour
{

    public Transform cubeTrans;
    public Transform ImageTrans;
    RectTransform imgPos;
    Vector2 pos;
    // Start is called before the first frame update
    void Start()
    {
         imgPos = ImageTrans.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 worldToScreen = Camera.main.WorldToScreenPoint(cubeTrans.position);
        RectTransformUtility.ScreenPointToLocalPointInRectangle(ImageTrans.parent.GetComponent<RectTransform>(),worldToScreen,Camera.main,out pos);
        //Vector3 screenToViewport = Camera.main.ScreenToViewportPoint(worldToScreen);
        imgPos.anchoredPosition = pos;
      //  Debug.Log(screenToViewport);
    }
}
