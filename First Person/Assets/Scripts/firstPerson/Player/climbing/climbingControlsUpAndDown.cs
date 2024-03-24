using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class climbingControlsUpAndDown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.GetComponent<climbing>().currentlyClimbing)
        {
            if (Input.GetKey("w"))
            {
                this.transform.Translate(0.01f * (Vector3.up));
            }

            if (Input.GetKey("s"))
            {
                this.transform.Translate(0.01f * (Vector3.down));
            }
        }
    }
}
