using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetOrderFromWaiter : GAction
{
    public override bool PrePerform() {
        // var world = GWorld.Instance.GetWorld();
        // var readyOrders = world.HasState("ReadyOrders");
        // if (!readyOrders) return false;
        return true;
    }

    public override bool PostPerform() {
        var world = GWorld.Instance.GetWorld();
        world.ModifyState("ReadyOrders", -1);
        return true;
    }
}
