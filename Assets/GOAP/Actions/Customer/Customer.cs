using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : GAgent
{
    // Start is called before the first frame update
    new void Start() {
        base.Start();
        SubGoal placeOrder = new SubGoal("PlaceOrder", 1, true);
        SubGoal eat = new SubGoal("Eat", 1, true);
        SubGoal leave = new SubGoal("Leave", 1, true);
        goals.Add(placeOrder, 1);
        goals.Add(eat, 2);
        goals.Add(leave,3);
        beliefs.ModifyState("GoToRestaurant", 1);
    }
}
