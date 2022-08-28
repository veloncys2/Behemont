using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public float openAngle;
    public bool isLocked = false;

    bool isOpen = false;
    Quaternion startRot;

    private void Start()
    {
        startRot = transform.rotation;
    }

    public void CheckDoor()
    {
        if (!isOpen)
            isOpen = !isOpen;
        else if (isOpen)
            isOpen = !isOpen;
    }

    private void Update()
    {
        Quaternion currentRot = transform.rotation;
        Quaternion newRot = Quaternion.Euler(transform.eulerAngles.x, openAngle, transform.eulerAngles.z);

        if (isOpen)
            transform.rotation = Quaternion.Lerp(currentRot, newRot, 0.5f);
        else
            transform.rotation = Quaternion.Lerp(currentRot, startRot, 0.5f);
        if (isLocked == true)
            transform.rotation = startRot;
    }
}
