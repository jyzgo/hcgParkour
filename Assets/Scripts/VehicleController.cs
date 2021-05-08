using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    public float speed;
    
    void Update()
    {
        Vector3 currentPosition = transform.position;
        transform.position = currentPosition + new Vector3(-speed * Time.deltaTime , 0, 0);
    }

    public void ChangeVehicle(int vehicleType)
    {
        for(int i = 0; i < 3; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
        switch (vehicleType)
        {
            case 0:
                gameObject.tag = "Highway";               
                break;
            case 1:
                gameObject.tag = "Desert";
                break;
            case 2:
                gameObject.tag = "Sea";
                break;
        }
        transform.GetChild(vehicleType).gameObject.SetActive(true);
    }
}
