using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerLevel
{
    public int cost;
    public float speed;
    public int level;

    public TowerLevel()
    {
        //Attack speed
        speed = 110f;
        //Tower money cost (wip)
        cost = 10;
        //Level counters
        level = 0;
    }
}
