using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
using System;
using System.Text;

public class Injection
{
    public string name;
    public GameObject value;
}

[LuaCallCSharp]
public class LuaBehaviour : MonoBehaviour
{
    private static int CurIndex = 0;

    public string LuaPath;
    public Injection[] Injections;
    protected float m_delayTime = 1.0f;           //延迟循环的时间
    protected float m_curTime = 0f;               //当前计时
    protected float m_luaUpdateTime = 0f;         //lua心跳时间
    protected bool m_Init = false;                //是否初始化过了
    protected int m_Index = 0;
    protected LuaTable scriptEnv;
    protected Action luaAwake;
    protected Action luaStart;
    protected Action luaUpdate;
    protected Action<float> luaUpdateLua;
    protected Action luaUpdatebySecond;          //1秒循环一次的Update
    protected Action luaOnEnable;
    protected Action luaOnDisable;
    protected Action luaOnDestroy;
    protected Action luaOnShow;
    protected Action luaOnHide;
    protected Action<string> luaOnParam;

    public int Index
    {
        get { return m_Index; }
    }

    protected virtual void Awake()
    {

        InitLua();
        if (luaAwake != null)
        {
#if UNITY_EDITOR
            //ObjectTranslator.CurLuaBehaviour = this;
#endif
            luaAwake();
        }
    }
    public string GetPath()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(name);
        Transform t = transform.parent;
        while (t != null)
        {
            sb.Insert(0, t.name + ".");
            t = t.parent;
        }
        return sb.ToString();
    }

    public virtual void OnShow() { }
    public virtual void OnHide() { }

    public LuaTable InitLua()
    {
        if (m_Init)
        {
            return scriptEnv;
        }
        m_Init = true;

        if (string.IsNullOrEmpty(LuaPath.Trim()))
        {
            return null;
        }

        var luaText = LuaMgr.LoadLua(LuaPath, true);
        if (luaText == null)
        {
            SG.Debuger.LogError("Can not load this Lua script: " + LuaPath);
            return null;
        }

        LuaEnv luaG = LuaMgr.Instance.GetLuaEnv();

        scriptEnv = luaG.NewTable();

        LuaTable meta = luaG.NewTable();
        meta.Set("__index", luaG.Global);
        scriptEnv.SetMetaTable(meta);
        meta.Dispose();
        meta = null;

        scriptEnv.Set("self", this);
        if (Injections != null)
        {
            for (int i = 0; i < Injections.Length; i++)
            {
                var injection = Injections[i];
                if (!string.IsNullOrEmpty(injection.name) && injection.value != null)
                {
                    scriptEnv.Set(injection.name, injection.value);
                }
            }
        }
        Debug.Log("luapath = " + LuaPath);
        luaG.DoString(luaText, LuaPath + ".txt", scriptEnv);

        scriptEnv.Get("Awake", out luaAwake);
        scriptEnv.Get("Start", out luaStart);
        scriptEnv.Get("Update", out luaUpdate);
        scriptEnv.Get("UpdateLua", out luaUpdateLua);
        scriptEnv.Get("UpdateBySecond", out luaUpdatebySecond);
        scriptEnv.Get("OnEnable", out luaOnEnable);
        scriptEnv.Get("OnDisable", out luaOnDisable);
        scriptEnv.Get("OnDestroy", out luaOnDestroy);
        scriptEnv.Get("OnShow", out luaOnShow);
        scriptEnv.Get("OnHide", out luaOnHide);
        scriptEnv.Get("OnParam", out luaOnParam);
        m_Index = CurIndex++;
        LuaMgr.AddLua(this);
        return scriptEnv;
    }

    public virtual void DoClose()
    {
        DoHide();
    }

    [BlackList]
    public virtual bool DoHide()
    {
        OnHide();
        gameObject.SetActive(false);
        if (luaOnHide != null)
        {
            luaOnHide();
        }
        return true;
    }
    public virtual void DoShow(string strParam = "")
    {
        gameObject.SetActive(true);
        if (luaOnShow != null)
        {
            luaOnShow();
        }
        OnParam(strParam);
        OnShow();
    }

    protected virtual void OnParam(string strParam)
    {
        if (luaOnParam != null)
        {
            luaOnParam(strParam);
        }
    }
    // Use this for initialization
    protected virtual void Start()
    {
        if (luaStart != null)
        {
#if UNITY_EDITOR
            //ObjectTranslator.CurLuaBehaviour = this;
#endif
            luaStart();
        }
    }

    protected virtual void Update()
    {
        if (luaUpdate != null)
        {
#if UNITY_EDITOR
            //ObjectTranslator.CurLuaBehaviour = this;
#endif
            luaUpdate();
        }

        if (luaUpdatebySecond != null)
        {
#if UNITY_EDITOR
            //ObjectTranslator.CurLuaBehaviour = this;
#endif
            if (m_curTime < m_delayTime)
            {
                m_curTime += Time.deltaTime;
            }
            else
            {
                m_curTime = 0;
                luaUpdatebySecond();
            }

        }

        if (luaUpdateLua != null)
        {
            m_luaUpdateTime += Time.deltaTime;
            if (m_luaUpdateTime > 0.1f)
            {
                luaUpdateLua(m_luaUpdateTime);
                m_luaUpdateTime = 0f;
            }
        }
    }

    protected virtual void OnEnable()
    {
        if (luaOnEnable != null)
        {
#if UNITY_EDITOR
            //ObjectTranslator.CurLuaBehaviour = this;
#endif
            luaOnEnable();
        }

    }
}
