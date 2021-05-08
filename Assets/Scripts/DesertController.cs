using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesertController : MonoBehaviour
{
    public int desertSpeed;
    public int desertSlowSpeed;
    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Desert")
        {
            other.GetComponent<VehicleController>().speed = desertSpeed;
        }
        else
        {
            other.GetComponent<VehicleController>().speed = desertSlowSpeed;
        }

    }
}
