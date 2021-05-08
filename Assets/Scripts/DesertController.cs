using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveController: MonoBehaviour
{
    public string moveTag = "";

    public float normalSpeed = 0f;
    public float slowSpeed = 0;
    VehicleController _vc = null;
    private void OnTriggerEnter(Collider other)
    {
        _vc = other.GetComponent<VehicleController>();
        if(_vc != null)
        {
            var otherTag = other.gameObject.tag;
            if(otherTag.Equals(moveTag))
            {
                _vc.speed = normalSpeed;
            }else
            {
                _vc.speed =slowSpeed;
            }

        }
    }
}

public class DesertController : MoveController
{
    private void Awake()
    {
        moveTag = ParkourConf.DESERT_TAG;
        normalSpeed = ParkourConf.DESERT_NORMAL_SPEED;
        slowSpeed = ParkourConf.DESERT_SLOW_SPEED;
    }
}
