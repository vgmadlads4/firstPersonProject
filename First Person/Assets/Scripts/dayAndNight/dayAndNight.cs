using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dayAndNight : MonoBehaviour
{
    public int days;
    public int minutes;
    public int seconds;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(oneSecond());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator oneSecond()
    {
        while (seconds < 60)
        {
            yield return new WaitForSeconds(1);
            seconds++;
        }
        StartCoroutine(oneMinute());
        yield return null;
    }


    private IEnumerator oneMinute()
    {
        minutes++;
        seconds = 0;
        if (minutes > 25)
        {
            minutes = 0;
            days++;
        }
        StartCoroutine(oneSecond());
        yield return null;
    }
}
