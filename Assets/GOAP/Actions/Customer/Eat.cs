﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : GAction {
    public override bool PrePerform() {
        GameObject o = inventory.items.Find(item => item.CompareTag("Order"));
        if (!o) return false;
        inventory.items.Remove(o);
        return true;
    }

    public override bool PostPerform() {
        GWorld world = GWorld.Instance;
        GameObject t = inventory.items.Find(item => item.CompareTag("Order"));
        t.GetComponent<Table>().customer = null;
        world.FreeTable(t);
        return true;
    }
}
