using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerJumpTwo : MonoBehaviour
{
    public int numberOfButtonPresses;
    public bool stopTheButton;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody>().freezeRotation = true;
        stopTheButton = true;
        numberOfButtonPresses = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (stopTheButton)
        {
            if (this.GetComponent<justFalling>().returnCanJumpStatus())
            {
                if (Input.GetKeyDown("space"))
                {
                    this.GetComponent<Rigidbody>().AddForce(3000f * Vector3.up);
                    StartCoroutine(stoppingButton());
                }
            }
        }
    }

    public IEnumerator stoppingButton()
    {
        stopTheButton = false;
        yield return new WaitUntil(() => this.GetComponent<justFalling>().returnCanJumpStatus());
        stopTheButton = true;
    }
}
