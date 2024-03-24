using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTopOfLadder : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("onTopOfClimbable"))
        {
            this.GetComponent<fallDamage>().enabled = false;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("onTopOfClimbable"))
        {
            this.GetComponent<fallDamage>().enabled = true;
        }

    }
}
