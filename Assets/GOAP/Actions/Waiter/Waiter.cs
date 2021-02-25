using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waiter : GAgent
{
    // Start is called before the first frame update
    new void Start() {
        base.Start();
        
        SubGoal placeOrders = new SubGoal("PlaceOrder", 1, false);
        SubGoal deliver = new SubGoal("DeliverOrder", 1, false);
        goals.Add(placeOrders, 3);
        goals.Add(deliver,3);
    }
}
