using UnityEngine;
using System;

public class UIAnimationEvent : MonoBehaviour
{
    public Action<string> Handle;
    public void TriggerUIEvent(string eventStr)
    {
        if (Handle == null)
        {
            return;
        }
        Handle(eventStr);
    }

    public void InitProxyCall(Action<string> luaFunc)
    {
        if (Handle != null)
        {
            return;
        }
        Handle = luaFunc;
    }

    public void ClearProxyCall()
    {
        Handle = null;
    }
    private void OnDestroy()
    {
        ClearProxyCall();
    }
}
