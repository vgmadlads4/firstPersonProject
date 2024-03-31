using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerGettingHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("enemyBullet"))
        {
            this.GetComponent<playerStats>().healthReducation(5);
        }
    }
}
