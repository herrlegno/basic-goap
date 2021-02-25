using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : GAgent
{
    // Start is called before the first frame update
    new void Start() {
        base.Start();
        SubGoal waitOrder = new SubGoal("WaitOrder", 1, true);
        SubGoal eat = new SubGoal("Eat", 1, true);
        goals.Add(waitOrder, 3);
        goals.Add(eat, 3);
    }
}
