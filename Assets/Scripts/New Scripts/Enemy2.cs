using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2: EnemyNew
{
    public override void Behavior()
    {
        base.Behavior();
        GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -2f);
    }
    // rbs.velocity = new Vector2(0f, -2f);
}
