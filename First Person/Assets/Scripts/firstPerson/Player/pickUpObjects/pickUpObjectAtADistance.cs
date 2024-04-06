using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pickUpObjectAtADistance : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.parent.parent.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit playerInteractRay;
        Vector3 pickUpItem = this.gameObject.transform.position;
        if (Physics.Raycast(pickUpItem, 1f * this.gameObject.transform.forward, out playerInteractRay, 1.0f))
        {
            if (playerInteractRay.transform.tag == "pickUpable" && (!this.GetComponent<pickUpObject>().itemPickedUp()))
            {
                this.transform.parent.parent.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "Press E to Pick Up";
            }
            else
            {
                this.transform.parent.parent.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "";
            }
        }
        else
        {
            this.transform.parent.parent.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "";
        }
    }
}
