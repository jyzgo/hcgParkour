using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaController : MonoBehaviour
{
    public int seaSpeed;
    public int seaSlowSpeed;
    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Sea")
        {
            other.GetComponent<VehicleController>().speed = seaSpeed;
        }
        else
        {
            other.GetComponent<VehicleController>().speed = seaSlowSpeed;
        }

    }
}
