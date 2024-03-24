using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class climbing : MonoBehaviour
{
    public bool currentlyClimbing = false;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Climbable"))
        {
            this.GetComponent<Rigidbody>().useGravity = false;
            currentlyClimbing = true;
            this.GetComponent<fallDamage>().enabled = false;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Climbable"))
        {
            this.GetComponent<Rigidbody>().useGravity = true;
            currentlyClimbing = false;
            this.GetComponent<fallDamage>().enabled = true;
        }

    }
}
