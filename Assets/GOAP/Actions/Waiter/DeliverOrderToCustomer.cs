using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliverOrderToCustomer : GAction
{
    public override bool PrePerform() {
        return true;
    }

    public override bool PostPerform() {
        var world = GWorld.Instance.GetWorld();
        world.ModifyState("ReadyOrders", 1);
        return true;
    }
}
