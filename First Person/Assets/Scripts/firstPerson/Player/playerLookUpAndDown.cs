using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLookUpAndDown : MonoBehaviour
{
    private int currentRotation = 0;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.FindWithTag("MainCamera").transform.rotation = Quaternion.Euler(currentRotation, GameObject.FindWithTag("MainCamera").transform.rotation.eulerAngles.y, GameObject.FindWithTag("MainCamera").transform.rotation.eulerAngles.z);
        if (Input.GetAxis("Mouse Y") > 0 && currentRotation >-90)
        {
            currentRotation--;
        }
        if (Input.GetAxis("Mouse Y") < 0 && currentRotation < 90)
        {
            currentRotation++;
        }
    }
}
