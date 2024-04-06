using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpObject : MonoBehaviour
{
    private bool currentlyholding;
    // Start is called before the first frame update
    void Start()
    {
        currentlyholding = false;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit playerInteractRay;
        Vector3 pickUpItem = this.gameObject.transform.position;
        if (!currentlyholding)
        {
            if (Physics.Raycast(pickUpItem, 1f * this.gameObject.transform.forward, out playerInteractRay,1.0f))
            {
                if (Input.GetKeyDown("e") && playerInteractRay.transform.tag == "pickUpable")
                {
                    playerInteractRay.transform.parent = this.gameObject.transform;
                    playerInteractRay.transform.gameObject.AddComponent<FixedJoint>();
                    playerInteractRay.transform.GetComponent<FixedJoint>().connectedBody = this.GetComponent<Rigidbody>();
                    playerInteractRay.transform.GetComponent<FixedJoint>().breakForce = 8000;
                    Physics.IgnoreCollision(this.transform.parent.parent.parent.GetComponent<Collider>(), playerInteractRay.transform.GetComponent<Collider>());
                    currentlyholding = true;
                }
            }
        }

        else
        {
            if (this.transform.GetChild(0).GetComponent<FixedJoint>() == null)
            {
                this.transform.DetachChildren();
                currentlyholding = false;
            }

            if (Input.GetKeyDown("e")){
                Destroy(this.transform.GetChild(0).GetComponent<FixedJoint>());
                this.transform.DetachChildren();
                currentlyholding = false;
            }

            if (Input.GetMouseButtonDown(1))
            {
                Destroy(this.transform.GetChild(0).GetComponent<FixedJoint>());
                this.transform.GetChild(0).gameObject.GetComponent<Rigidbody>().AddForce(100 * this.GetComponent<Transform>().forward);
                this.transform.DetachChildren();
                currentlyholding = false;
            }
        }
    }

    public bool itemPickedUp()
    {
        return currentlyholding;
    }
}
