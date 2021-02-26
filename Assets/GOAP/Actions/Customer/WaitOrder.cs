using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitOrder : GAction
{
    public override bool PrePerform() {
        GameObject t = GWorld.Instance.ReserveTable();
        if (!t) return false;
        target = t;
        t.GetComponent<Table>().customer = agent.gameObject.GetComponent<GAgent>();
        return true;
    }

    public override bool PostPerform() {
        beliefs.RemoveState("GoToRestaurant");
        return true;
    }
}
