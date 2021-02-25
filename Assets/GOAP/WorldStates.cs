using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor.PackageManager;
using Debug = UnityEngine.Debug;

[System.Serializable]
public class WorldState
{
    public string key;
    public int value;
}

public class WorldStates
{
    public Dictionary<string, int> states;

    public WorldStates()
    {
        states = new Dictionary<string, int>();
    }

    public int GetState(string key) {
        if (!HasState(key)) throw new Exception(key + "Not found");
        return states[key];
    }

    public bool HasState(string key)
    {
        return states.ContainsKey(key);
    }

    void CreateState(string key, int value)
    {
        states.Add(key, value);
    }

    public void ModifyState(string key, int value)
    {
        if (HasState(key))
        {
            states[key] += value;
            if (states[key] <= 0)
                RemoveState(key);
        }
        else
            CreateState(key, value);
        
    }

    public void RemoveState(string key)
    {
        if (HasState(key))
            states.Remove(key);
    }

    public void SetState(string key, int value)
    {
        if (HasState(key))
            states[key] = value;
        else
            CreateState(key, value);
    }

    public Dictionary<string, int> GetStates()
    {
        return states;
    }
}
