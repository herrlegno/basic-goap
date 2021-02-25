using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForTable : GAction {
    public override bool PrePerform() {
        // try {
        //     int availables = GWorld.Instance.GetWorld().GetState("AvailableTables");
        //     return availables > 0;
        // }
        // catch {
        //     Debug.Log("no hay mesas");
        //     return false;
        // }
        GameObject t = GWorld.Instance.ReserveTable();
        if (!t) return false;
        target = t;
        t.GetComponent<Table>().customer = agent.gameObject.GetComponent<GAgent>();
        return true;
    }

    public override bool PostPerform() {
        return true;
    }
}
