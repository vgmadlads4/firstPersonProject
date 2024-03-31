using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class climbingControls : MonoBehaviour
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
            if (Input.GetKey("a"))
            {
                this.transform.Translate(0.01f * (Vector3.left));
            }

            if (Input.GetKey("d"))
            {
                this.transform.Translate(0.01f * (Vector3.right));
            }
        }

    }
}
