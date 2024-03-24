using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStats : MonoBehaviour
{
    private int health;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void decreaseHealth(float distanceFell)
    {
        float healthDecrease = (float) (0.001 * Mathf.Exp(distanceFell));
        health -= Mathf.RoundToInt(healthDecrease);
        if(health <= 0)
        {
            Destroy(this.GetComponent<GameObject>());
        }
    }

    public void healthReducation(int healthRemoved)
    {
        health -= healthRemoved;
        if (health <= 0)
        {
            Destroy(this.GetComponent<GameObject>());
        }
    }
}
