using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sixHours : MonoBehaviour
{
    public int hours;
    public int minutes;
    public int seconds;
    public AudioClip tickingSound;
    public AudioClip alarm;
    public AudioSource theSource;

    void Start()
    {
        theSource = this.GetComponent<AudioSource>();
        StartCoroutine(oneSecond());
    }


    private IEnumerator oneSecond()
    {
        while (seconds < 60)
        {
            yield return new WaitForSeconds(1);
            seconds++;
            theSource.clip = tickingSound;
            theSource.Play();
        }
        StartCoroutine(oneMinute());
        yield return null;
    }


    private IEnumerator oneMinute()
    {
        minutes++;
        theSource.clip = alarm;
        theSource.Play();
        seconds = 0;
        if (minutes > 5)
        {
            minutes = 0;
            hours++;
            if (hours >6)
            {
                StartCoroutine(afterSixHours());
            }

        }
        StartCoroutine(oneSecond());
        yield return null;
    }

    private IEnumerator afterSixHours()
    {
        yield return null;
    }



}
