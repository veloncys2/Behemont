using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour
{
    public Image crosshair;  
    public float distance;
    RaycastHit hit;

    public GameObject flashLight;
    bool flashlight;

    void Start()
    {
        flashLight.SetActive(false);
    }

    void Update()
    {
        crosshair.color = new Color(0, 0, 0, 0);

        if (Physics.Raycast(transform.position, transform.forward , out hit, 5))
        {
            Debug.DrawRay(transform.position, transform.forward, Color.red);

            if (hit.distance <= distance && hit.transform.gameObject.tag == "Key" || hit.transform.gameObject.tag == "Door")
            {
                crosshair.color = Color.red;
            }
        }
    }

    public void takeObject()
    {
        if (hit.collider.gameObject.tag == "Key")
        {
            Destroy(hit.transform.gameObject);
        }
    }

    public void openDoor()
    {
        if (hit.collider.gameObject.tag == "Door")
        {
            hit.transform.GetComponent<DoorController>().CheckDoor();
        }
    }

    public void openflashLight()
    {
        flashlight = !flashlight;
        flashLight.SetActive(flashlight);
            
    }
}
