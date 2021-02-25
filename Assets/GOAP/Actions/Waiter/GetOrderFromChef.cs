using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetOrderFromChef : GAction
{
    public override bool PrePerform() {
        GameObject t = GWorld.Instance.GetCookedOrder();
        if (!t) return false;
        inventory.AddItem(t);
        return true;
    }

    public override bool PostPerform() {
        return true;
    }
}
