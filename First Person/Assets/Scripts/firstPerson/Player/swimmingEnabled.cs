using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swimmingEnabled : MonoBehaviour
{
    private bool currentlySwimming = false;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Swimmable"))
        {
            this.GetComponent<Rigidbody>().useGravity = false;
            currentlySwimming = true;
            this.GetComponent<leftAndRight>().enabled = false;
            this.GetComponent<upAndDown>().enabled = false;
            this.GetComponent<fallDamage>().enabled = false;
            this.GetComponent<justFalling>().enabled = false;
            this.GetComponent<playerJumpTwo>().enabled = false;
            this.GetComponent<diveUpAndDown>().enabled = true;
            this.GetComponent<swimming>().enabled = true;
            this.GetComponent<Rigidbody>().isKinematic = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Swimmable"))
        {
            this.GetComponent<Rigidbody>().useGravity = true;
            currentlySwimming = false;
            this.GetComponent<leftAndRight>().enabled = true;
            this.GetComponent<upAndDown>().enabled = true;
            this.GetComponent<fallDamage>().enabled = true;
            this.GetComponent<justFalling>().enabled = true;
            this.GetComponent<playerJumpTwo>().enabled = true;
            this.GetComponent<diveUpAndDown>().enabled = false;
            this.GetComponent<swimming>().enabled = false;
            this.GetComponent<Rigidbody>().isKinematic = false;
        }

    }

    public bool returnSwimmingStatus()
    {
        return currentlySwimming;
    }
}
