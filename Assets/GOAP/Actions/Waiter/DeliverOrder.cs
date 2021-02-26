using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliverOrder : GAction
{
    public override bool PrePerform() {
        GameObject o = inventory.items.Find(item => item.CompareTag("Order"));
        target = o;
        return true;
    }

    public override bool PostPerform() {
        GameObject o = inventory.items.Find(item => item.CompareTag("Order"));
        o.GetComponent<Table>().customer.inventory.AddItem(o);
        o.GetComponent<Table>().customer.beliefs.ModifyState("GotOrder", 1);
        inventory.RemoveItem(o);
        return true;
    }
}
