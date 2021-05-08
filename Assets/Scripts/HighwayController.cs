using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighwayController : MonoBehaviour
{
    public int highwaySpeed;
    public int highwaySlowSpeed;
    public int highwayStopSpeed;
    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Highway")
        {
            other.GetComponent<VehicleController>().speed = highwaySpeed;
        } 
        else
        {
            other.GetComponent<VehicleController>().speed = highwaySlowSpeed;
        } 
    }
}
