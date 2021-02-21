using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetOrderFromChef : GAction
{
    public override bool PrePerform() {
        var world = GWorld.Instance.GetWorld();
        var readyOrders = world.HasState("CookedOrders");
        if (!readyOrders) return false;
        return true;
    }

    public override bool PostPerform() {
        var world = GWorld.Instance.GetWorld();
        world.ModifyState("CookedOrders", -1);
        return true;
    }
}
