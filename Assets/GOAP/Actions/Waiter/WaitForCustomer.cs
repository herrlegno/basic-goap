using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForCustomer : GAction
{
    public override bool PrePerform() {
        return true;
    }

    public override bool PostPerform() {
        var t = GWorld.Instance.GetTable();
        if (!t) return false;
        inventory.AddItem(t);
        return true;
    }
}
