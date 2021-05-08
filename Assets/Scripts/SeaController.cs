using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaController :MoveController
{
    private void Awake()
    {
        moveTag = ParkourConf.SEA_TAG;
        normalSpeed = ParkourConf.SEA_NOARMAL_SPEED;
        slowSpeed = ParkourConf.SEA_SLOW_SPEED;
    }
}
