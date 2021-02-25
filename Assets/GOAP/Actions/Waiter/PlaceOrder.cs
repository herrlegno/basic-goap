using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceOrder : GAction
{
    public override bool PrePerform() {
        var t = inventory.items.Find(item => item.CompareTag("Table"));
        if (!t) return false;
        target = t;
        return true;
    }

    public override bool PostPerform() {
        var t = inventory.items.Find(item => item.CompareTag("Table"));
        t.tag = "Order";
        GWorld.Instance.AddOrder(t);
        inventory.RemoveItem(t);
        return true;
    }
}
