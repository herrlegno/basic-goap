﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoAway : GAction
{
    public override bool PrePerform() {
        return true;
    }

    public override bool PostPerform() {
        beliefs.ModifyState("Hungry", 1);
        return true;
    }
}
