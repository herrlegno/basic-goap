using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : GAgent
{
    // Start is called before the first frame update
    new void Start() {
        base.Start();
        SubGoal hungry = new SubGoal("EatSomething", 1, false);
        goals.Add(hungry, 3);
        beliefs.ModifyState("Hungry", 1);
    }
}
