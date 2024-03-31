using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLookAround : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse X") > 0)
        {
            GameObject.FindWithTag("MainCamera").transform.rotation = Quaternion.Euler(GameObject.FindWithTag("MainCamera").transform.rotation.eulerAngles.x, GameObject.FindWithTag("MainCamera").transform.rotation.eulerAngles.y + 1f, GameObject.FindWithTag("MainCamera").transform.rotation.eulerAngles.z);
        }
        if (Input.GetAxis("Mouse X") < 0)
        {
            GameObject.FindWithTag("MainCamera").transform.rotation = Quaternion.Euler(GameObject.FindWithTag("MainCamera").transform.rotation.eulerAngles.x, GameObject.FindWithTag("MainCamera").transform.rotation.eulerAngles.y - 1f, GameObject.FindWithTag("MainCamera").transform.rotation.eulerAngles.z);
        }
    }
}
