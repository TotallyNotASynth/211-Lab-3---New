using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : EnemyNew
{

    public override void Behavior()
    {
        //Calls behavior from base script
        base.Behavior();
        //Sets enemy speed.
        GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -1f);
    }
    //rbs.

}
