using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DFEventCenter
{
    static Dictionary<DFEventType, Delegate> m_EventTable = new Dictionary<DFEventType, Delegate>();
    
    static void IAddListener(DFEventType eventType, Delegate callBack)
    {
        if (!m_EventTable.ContainsKey(eventType))
        {
            m_EventTable.Add(eventType, null);
        }
        Delegate d = m_EventTable[eventType];
        if (d != null && d.GetType() != callBack.GetType())
        {
            throw new Exception("AddListener Error: type err");
        }
    }
    public static void AddListener(DFEventType eventType, DFCallBack callBack)
    {
        IAddListener(eventType, callBack);
        m_EventTable[eventType] = (DFCallBack)m_EventTable[eventType] + callBack;
    }
    public static void AddListener<T>(DFEventType eventType, DFCallBack<T> callBack)
    {
        IAddListener(eventType, callBack);
        m_EventTable[eventType] = (DFCallBack<T>)m_EventTable[eventType] + callBack;
    }
    public static void AddListener<T,X>(DFEventType eventType, DFCallBack<T, X> callBack)
    {
        IAddListener(eventType, callBack);
        m_EventTable[eventType] = (DFCallBack<T, X>)m_EventTable[eventType] + callBack;
    }
    public static void AddListener<T, X,Y>(DFEventType eventType, DFCallBack<T, X, Y> callBack)
    {
        IAddListener(eventType, callBack);
        m_EventTable[eventType] = (DFCallBack<T, X, Y>)m_EventTable[eventType] + callBack;
    }
    public static void AddListener<T, X, Y, Z>(DFEventType eventType, DFCallBack<T, X, Y, Z> callBack)
    {
        IAddListener(eventType, callBack);
        m_EventTable[eventType] = (DFCallBack<T, X, Y, Z>)m_EventTable[eventType] + callBack;
    }
    static void IRemoveListener(DFEventType eventType, Delegate callBack)
    {
        if (m_EventTable.ContainsKey(eventType))
        {
            Delegate d = m_EventTable[eventType];
            if (d == null)
                throw new Exception("RemoveListener Error: doesnot exist the delegate of the removed event !["+eventType+"]");
            else if (d.GetType() != callBack.GetType())
                throw new Exception("RemoveListener Error: the removed event has a diff type!");
        }
        else
        {
            throw new Exception("RemoveListener Error: m_EventTable is not contaioned eventType!");
        }
    }
    public static void RemoveListener(DFEventType eventType, DFCallBack callBack)
    {
        IRemoveListener(eventType, callBack);
        m_EventTable[eventType] = (DFCallBack)m_EventTable[eventType] - callBack;
    }
    public static void RemoveListener<T>(DFEventType eventType, DFCallBack<T> callBack)
    {
        IRemoveListener(eventType, callBack);
        m_EventTable[eventType] = (DFCallBack<T>)m_EventTable[eventType] - callBack;
    }
    public static void RemoveListener<T, X>(DFEventType eventType, DFCallBack<T, X> callBack)
    {
        IRemoveListener(eventType, callBack);
        m_EventTable[eventType] = (DFCallBack<T, X>)m_EventTable[eventType] - callBack;
    }
    public static void RemoveListener<T, X,Y>(DFEventType eventType, DFCallBack<T, X,Y> callBack)
    {
        IRemoveListener(eventType, callBack);
        m_EventTable[eventType] = (DFCallBack<T, X,Y>)m_EventTable[eventType] - callBack;
    }
    public static void RemoveListener<T, X, Y, Z>(DFEventType eventType, DFCallBack<T, X, Y, Z> callBack)
    {
        IRemoveListener(eventType, callBack);
        m_EventTable[eventType] = (DFCallBack<T, X, Y, Z>)m_EventTable[eventType] - callBack;
    }
    public static void Broadcast(DFEventType eventType)
    {
        Delegate d;
        if (m_EventTable.TryGetValue(eventType, out d))
        {
            DFCallBack callBack = d as DFCallBack;
            if (callBack != null)
                callBack();
            else
                throw new Exception("Broadcast Error: the callBack is null!");
        }
    }
    public static void Broadcast<T>(DFEventType eventType, T arg1)
    {
        Delegate d;
        if (m_EventTable.TryGetValue(eventType, out d))
        {
            DFCallBack<T> callBack = d as DFCallBack<T>;
            if (callBack != null)
                callBack(arg1);
            else
                throw new Exception("Broadcast Error: the callBack is null![" + eventType + "]");
        }
    }
    public static void Broadcast<T,X>(DFEventType eventType, T arg1, X arg2)
    {
        Delegate d;
        if (m_EventTable.TryGetValue(eventType, out d))
        {
            DFCallBack<T,X> callBack = d as DFCallBack<T,X>;
            if (callBack != null)
                callBack(arg1, arg2);
            else
                throw new Exception("Broadcast Error: the callBack is null![" + eventType + "]");
        }
    }
    public static void Broadcast<T, X,Y>(DFEventType eventType, T arg1, X arg2,Y arg3)
    {
        Delegate d;
        if (m_EventTable.TryGetValue(eventType, out d))
        {
            DFCallBack<T, X,Y> callBack = d as DFCallBack<T, X,Y>;
            if (callBack != null)
                callBack(arg1, arg2,arg3);
            else
                throw new Exception("Broadcast Error: the callBack is null![" + eventType + "]");
        }
    }
    public static void Broadcast<T, X, Y, Z>(DFEventType eventType, T arg1, X arg2, Y arg3, Z arg4)
    {
        Delegate d;
        if (m_EventTable.TryGetValue(eventType, out d))
        {
            DFCallBack<T, X, Y, Z> callBack = d as DFCallBack<T, X, Y, Z>;
            if (callBack != null)
                callBack(arg1, arg2, arg3, arg4);
            else
                throw new Exception("Broadcast Error: the callBack is null![" + eventType + "]");
        }
    }
    public static bool IsExist(DFEventType e)
    {
        if(m_EventTable.ContainsKey(e))
        {
            return true;
        }
        return false;
    }
    public static void IsExistAndRemove(DFEventType e)
    {
        if (m_EventTable.ContainsKey(e))
        {
            m_EventTable.Remove(e);
        }
    }
}
