using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : GAction {
    public override bool PrePerform() {
        GameObject o = inventory.items.Find(item => item.CompareTag("Order"));
        if (!o) return false;
        target = o.gameObject;
        beliefs.RemoveState("GotOrder");
        return true;
    }

    public override bool PostPerform() {
        GameObject t = inventory.items.Find(item => item.CompareTag("Order"));
        t.GetComponent<Table>().customer = null;
        t.tag = "Table";
        GWorld.Instance.FreeTable(t);
        return true;
    }
}
