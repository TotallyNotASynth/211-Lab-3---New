﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : EnemyNew
{
    public override void Behavior()
    {
        //Calls behavior from base script
        base.Behavior();
        //Sets enemy speed.
        GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -3f);
    }
    // rbs.velocity = new Vector2(0f, -3f);
}
