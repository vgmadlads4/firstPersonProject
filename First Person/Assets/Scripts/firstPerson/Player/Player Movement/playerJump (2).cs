using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerJump : MonoBehaviour
{
    public bool canJump;
    // Start is called before the first frame update
    void Start()
    {
        canJump = true;
        this.GetComponent<Rigidbody>().freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") && canJump)
        {
            this.GetComponent<Rigidbody>().AddForce(400f * Vector3.up);
            canJump = false;
            StartCoroutine(playerJumping());
        }
    }


    public IEnumerator playerJumping()
    {
        while (!canJump)
        {
            RaycastHit theGround;
            Vector3 thePlayersPosition = this.gameObject.GetComponent<Transform>().position;
            if (Physics.Raycast(thePlayersPosition, Vector3.down, out theGround))
            {
                if (theGround.distance < 0.5)
                {
                    canJump = true;
                }

            }
            yield return null;
        }
        yield return null;
    }


}
