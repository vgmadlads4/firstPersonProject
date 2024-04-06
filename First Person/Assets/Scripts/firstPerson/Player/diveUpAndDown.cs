using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diveUpAndDown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.GetComponent<swimmingEnabled>().returnSwimmingStatus())
        {
            if (this.GetComponent<runningScript>().isRunning())
            {
                if (Input.GetKey("w"))
                {
                    Vector3 newTranslate = new Vector3(GameObject.FindWithTag("MainCamera").transform.position.x, GameObject.FindWithTag("MainCamera").transform.forward.y, GameObject.FindWithTag("MainCamera").transform.forward.z);
                    this.transform.Translate(0.1f * (newTranslate.normalized));
                }

                if (Input.GetKey("s"))
                {
                    Vector3 newTranslate = new Vector3(GameObject.FindWithTag("MainCamera").transform.forward.x, GameObject.FindWithTag("MainCamera").transform.forward.y, GameObject.FindWithTag("MainCamera").transform.forward.z);
                    this.transform.Translate(-0.1f * (newTranslate.normalized));
                }
            }
            else
            {
                if (Input.GetKey("w"))
                {
                    Vector3 newTranslate = new Vector3(GameObject.FindWithTag("MainCamera").transform.forward.x, GameObject.FindWithTag("MainCamera").transform.forward.y, GameObject.FindWithTag("MainCamera").transform.forward.z);
                    this.transform.Translate(0.01f * (newTranslate.normalized));
                }

                if (Input.GetKey("s"))
                {
                    Vector3 newTranslate = new Vector3(GameObject.FindWithTag("MainCamera").transform.forward.x, GameObject.FindWithTag("MainCamera").transform.forward.y, GameObject.FindWithTag("MainCamera").transform.forward.z);
                    this.transform.Translate(-0.01f * (newTranslate.normalized));
                }
            }
        }
    }
}
