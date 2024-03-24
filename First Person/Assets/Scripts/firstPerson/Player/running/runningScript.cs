using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runningScript : MonoBehaviour
{
    private bool currentlyRunning;
    private bool startRunning;
    private int gainingBack = 20;
    private bool recordDropping;
    private bool recordRising;

    // Start is called before the first frame update
    void Start()
    {
        currentlyRunning = true;
        recordDropping = true;
        recordRising = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
            if (Input.GetKey(KeyCode.LeftShift) && currentlyRunning)
            {
                startRunning = true;
                StartCoroutine(downGradeRunning());
            }
            else
            {
                startRunning = false;
                StartCoroutine(regainRunning());
            }
    }

    public IEnumerator downGradeRunning()
    {
        if (recordDropping)
        {
            recordDropping = false;
            gainingBack--;
            yield return new WaitForSeconds(1);
            recordDropping = true;

            if (gainingBack <= 0)
            {
                currentlyRunning = false;
            }
        }
    }

    public IEnumerator regainRunning()
    {
        if (recordRising && gainingBack<20)
        {
            recordRising = false;
            gainingBack++;
            yield return new WaitForSeconds(1);
            recordRising = true;

            if (gainingBack > 0)
            {
                currentlyRunning = true;
            }
        }
    }

    public bool isRunning()
    {
        return startRunning;
    }
}
