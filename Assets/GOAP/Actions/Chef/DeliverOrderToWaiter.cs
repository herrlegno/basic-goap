using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliverOrderToWaiter : GAction
{
    public override bool PrePerform() {
        return true;
    }

    public override bool PostPerform() {
        var o = inventory.items.Find(item => item.CompareTag("Order"));
        GWorld.Instance.AddCookedOrder(o);
        inventory.RemoveItem(o);
        return true;
    }
}
