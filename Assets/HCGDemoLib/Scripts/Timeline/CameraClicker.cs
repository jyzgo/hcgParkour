using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClicker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null)
                {
                    CameraBtn rb;

                    if (rb = hit.transform.GetComponent<CameraBtn>())
                    {
                        if(rb.enabled == true)
                        {
                            rb.Press();
                        }
                    }
                }
            }
        }
    }
}
