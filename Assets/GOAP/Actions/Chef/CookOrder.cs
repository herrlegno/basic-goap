using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookOrder: GAction
{
    public override bool PrePerform() {
        var t = GWorld.Instance.CookOrder();
        if (!t) return false;
        inventory.AddItem(t);
        return true;
    }

    public override bool PostPerform() {
        return true;
    }
}
