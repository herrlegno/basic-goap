using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class GInventory
{
    public List<GameObject> items = new List<GameObject>();

    public void AddItem(GameObject i)
    {
        items.Add(i);
    }
    
    public void RemoveItem(GameObject i)
    {
        int indexToRemove = -1;
        foreach (GameObject g in items)
        {
            indexToRemove++;
            if (g == i)
                break;
        }
        if (indexToRemove > -1)
        {
            items.RemoveAt(indexToRemove);
        }
    }
}
