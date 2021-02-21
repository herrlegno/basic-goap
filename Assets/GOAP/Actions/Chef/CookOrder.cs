using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookOrder: GAction
{
    public override bool PrePerform() {
        var world = GWorld.Instance.GetWorld();
        var pendingOrders = world.HasState("PendingOrders");
        if (!pendingOrders) return false;
        GWorld.Instance.GetWorld().ModifyState("PendingOrders", -1);
        return true;
    }

    public override bool PostPerform() {
        return true;
    }
}
