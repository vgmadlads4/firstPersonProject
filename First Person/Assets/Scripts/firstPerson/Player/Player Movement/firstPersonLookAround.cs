using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstPersonLookAround : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void rotateRight()
    {
        this.transform.Rotate(0f, 0.1f, 0f);
    }

    public void rotateLeft()
    {
        this.transform.Rotate(0f, -0.1f, 0f);
    }

    public void rotateUp()
    {
        this.transform.Rotate(0.1f, 0f, 0f);
    }

    public void rotateDown()
    {
        this.transform.Rotate(0.1f, 0f, 0f);
    }
}
