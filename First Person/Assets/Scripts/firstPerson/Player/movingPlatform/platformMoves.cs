using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMoves : MonoBehaviour
{
    public GameObject pointOne;
    public GameObject pointTwo;
    public GameObject platform;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(platformMovingTowardsPointOne());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator platformMovingTowardsPointOne()
    {
        while (Vector3.Distance(platform.transform.position,pointOne.transform.position) > 0 )
        {
            platform.GetComponent<Transform>().position = Vector3.MoveTowards(platform.GetComponent<Transform>().position, pointOne.transform.position,0.01f);
            yield return null;
        }
        yield return new WaitForSeconds(5);
        StartCoroutine(platformMovingTowardsPointTwo());
        yield return null;
    }

    public IEnumerator platformMovingTowardsPointTwo()
    {
        while (Vector3.Distance(platform.transform.position, pointTwo.transform.position) > 0)
        {
            platform.GetComponent<Transform>().position = Vector3.MoveTowards(platform.GetComponent<Transform>().position, pointTwo.transform.position, 0.01f);
            yield return null;
        }
        yield return new WaitForSeconds(5);
        StartCoroutine(platformMovingTowardsPointOne());
        yield return null;
    }
}
