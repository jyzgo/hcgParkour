using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighwayController : MoveController
{
    private void Awake()
    {
        moveTag = ParkourConf.HIGHWAY_TAG;
        normalSpeed = ParkourConf.HIGHWAY_NORMAL_SPEED;
        slowSpeed = ParkourConf.HIGHWAY_SLOW_SPEED;

    }
}
