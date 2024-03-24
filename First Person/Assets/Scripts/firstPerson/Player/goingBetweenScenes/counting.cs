using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class counting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] theGameObjects = GameObject.FindGameObjectsWithTag("Player");
        if(theGameObjects.Length > 1)
        {
            for (int i = 1; i < theGameObjects.Length; i++)
            {
                Destroy(theGameObjects[i]);
            }
        }
    }
}
