using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waiter : GAgent
{
    // Start is called before the first frame update
    new void Start() {
        base.Start();
        SubGoal deliver = new SubGoal("DeliverOrder", 1, false);
        goals.Add(deliver, 3);
    }
}
