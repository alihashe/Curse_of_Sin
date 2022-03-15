using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stat
{
    [SerializeField] private int baseValue;

    private List<int> mods = new List<int>();

    public int GetValue()
    {
        int finalValue = baseValue;
        mods.ForEach(x => finalValue += x);
        return finalValue;
    }

    public void SetValue(int newValue)
    {
        baseValue = newValue;
    }

    public void AddMods(int modifiers)
    {
        if (modifiers != 0)
            mods.Add(modifiers);
    }

    public void RemoveMods(int modifiers)
    {
        if (modifiers != 0)
            mods.Remove(modifiers);
    }
}
