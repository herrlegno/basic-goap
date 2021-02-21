using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order : GAction
{
    public override bool PrePerform() {
        return true;
    }

    public override bool PostPerform() {
        GWorld.Instance.GetWorld().ModifyState("PendingOrders", 1);
        beliefs.RemoveState("Hungry");
        return true;
    }
}
