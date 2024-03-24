using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerWalkingAround : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if(!this.GetComponent<climbing>().currentlyClimbing)
        {
            if (Input.GetKey("w"))
            {
                Vector3 newTranslate = new Vector3(GameObject.FindWithTag("MainCamera").transform.forward.x, 0, GameObject.FindWithTag("MainCamera").transform.forward.z);
                this.transform.Translate(0.01f * (newTranslate.normalized));
            }

            if (Input.GetKey("s"))
            {
                Vector3 newTranslate = new Vector3(GameObject.FindWithTag("MainCamera").transform.forward.x, 0, GameObject.FindWithTag("MainCamera").transform.forward.z);
                this.transform.Translate(-0.01f * (newTranslate.normalized));
            }
        }
    }
}
