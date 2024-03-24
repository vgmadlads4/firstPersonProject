using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftAndRight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (!this.GetComponent<climbing>().currentlyClimbing)
        {
            if (this.GetComponent<runningScript>().isRunning())
            {
                if (Input.GetKey("a"))
                {
                    Vector3 newTranslate = new Vector3(GameObject.FindWithTag("MainCamera").transform.right.x, 0, GameObject.FindWithTag("MainCamera").transform.right.z);
                    this.transform.Translate(-0.1f * (newTranslate.normalized));
                }
                if (Input.GetKey("d"))
                {
                    Vector3 newTranslate = new Vector3(GameObject.FindWithTag("MainCamera").transform.right.x, 0, GameObject.FindWithTag("MainCamera").transform.right.z);
                    this.transform.Translate(0.1f * (newTranslate.normalized));
                }
            }
            else
            {
                if (Input.GetKey("a"))
                {
                    Vector3 newTranslate = new Vector3(GameObject.FindWithTag("MainCamera").transform.right.x, 0, GameObject.FindWithTag("MainCamera").transform.right.z);
                    this.transform.Translate(-0.01f * (newTranslate.normalized));
                }
                if (Input.GetKey("d"))
                {
                    Vector3 newTranslate = new Vector3(GameObject.FindWithTag("MainCamera").transform.right.x, 0, GameObject.FindWithTag("MainCamera").transform.right.z);
                    this.transform.Translate(0.01f * (newTranslate.normalized));
                }
            }
        }
    }
}