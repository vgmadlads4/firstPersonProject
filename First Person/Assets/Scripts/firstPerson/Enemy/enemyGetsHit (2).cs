using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyGetsHit : MonoBehaviour
{
    private int health = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void reducationInHealth(int amountReduced)
    {
        health -= amountReduced;
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}