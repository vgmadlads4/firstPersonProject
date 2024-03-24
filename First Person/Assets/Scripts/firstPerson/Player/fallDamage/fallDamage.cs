using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallDamage : MonoBehaviour
{
    float maximumHeight = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit theGroundDistance;
        Vector3 thePlayersPosition = this.gameObject.GetComponent<Transform>().position;
        if (Physics.Raycast(thePlayersPosition, Vector3.down, out theGroundDistance))
        {
            if (theGroundDistance.distance > maximumHeight && theGroundDistance.distance > 0.5)
                {
                    maximumHeight = theGroundDistance.distance;
                }
                if (theGroundDistance.distance < 0.5)
                {
                    this.GetComponent<playerStats>().decreaseHealth(maximumHeight);
                    maximumHeight = 0f;
                }
        }
    }
}
