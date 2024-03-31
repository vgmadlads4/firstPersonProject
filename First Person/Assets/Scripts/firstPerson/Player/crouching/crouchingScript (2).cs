using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crouchingScript : MonoBehaviour
{
    private Vector3 notCrouching;
    private bool currentlyCroutching;
    // Start is called before the first frame update
    void Start()
    {
        notCrouching = this.GetComponent<BoxCollider>().size;
        currentlyCroutching = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("c") && (!(currentlyCroutching)))
        {
            this.GetComponent<BoxCollider>().size = new Vector3(1.2f,0.2f, notCrouching.z);
            currentlyCroutching = true;
        }
        
        else if (Input.GetKeyDown("c") && (currentlyCroutching))
        {
            this.GetComponent<BoxCollider>().size = notCrouching;
            currentlyCroutching = false;
        }
        
    }
}
