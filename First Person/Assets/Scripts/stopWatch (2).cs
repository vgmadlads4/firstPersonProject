using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopWatch : MonoBehaviour
{
    private bool stopWatchStatus = false;
    private int runningCounting = 0;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Start"))
        {
            stopWatchStatus = true;
            StartCoroutine(startStopWatch());
        }
        if (other.CompareTag("End"))
        {
            stopWatchStatus = false;
            print(runningCounting);
        }
    }

    public IEnumerator startStopWatch()
    {
        while (stopWatchStatus)
        {
            yield return new WaitForSeconds(1);
            runningCounting++;
        }
        yield return null;
    }


}
