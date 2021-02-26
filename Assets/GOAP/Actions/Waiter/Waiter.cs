using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waiter : GAgent {
    // Start is called before the first frame update
    new void Start() {
        base.Start();

        SubGoal wait = new SubGoal("Wait", 1, false);
        SubGoal placeOrders = new SubGoal("PlaceOrder", 1, false);
        SubGoal deliver = new SubGoal("DeliverOrder", 1, false);
        goals.Add(wait, 1);
        goals.Add(placeOrders, 2);
        goals.Add(deliver, 3);
    }
}
