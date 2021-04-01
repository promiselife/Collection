using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public abstract class InstanceBehaviour<T> : BaseBehaviour where T : class
{
    private static T _Instance;

    protected virtual void Awake()
    {
        _Instance = this as T;
    }
    protected virtual void OnDestroy()
    {
        _Instance = null;
    }

    public static T Instance
    {
        get
        {
            return _Instance;
        }
    }
}