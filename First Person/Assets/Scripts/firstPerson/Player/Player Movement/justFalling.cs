using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class justFalling : MonoBehaviour
{
    private bool canJump;
    private Vector3 thePlayersPosition;
    private Ray theBottomOfPlayer;

    // Start is called before the first frame update
    void Start()
    {
        canJump = false;
    }

    // Update is called once per frame
    void Update()
    {
            thePlayersPosition = new Vector3(this.gameObject.GetComponent<Collider>().bounds.center.x, this.gameObject.GetComponent<Collider>().bounds.min.y, this.gameObject.GetComponent<Collider>().bounds.center.z);
            theBottomOfPlayer = new Ray(thePlayersPosition, Vector3.down);
            RaycastHit theGround;
            if (Physics.Raycast(theBottomOfPlayer, out theGround))
            {
                if (theGround.distance < 0.4)
                {
                    canJump = true;
                }
                else
                {
                    canJump = false;
                }
            }
    }

    public bool returnCanJumpStatus()
    {
        return canJump;
    }
}
