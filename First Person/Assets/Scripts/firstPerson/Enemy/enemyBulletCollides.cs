using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBulletCollides : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag.Equals("Ground"))
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            Destroy(this.gameObject);
        }
        if (other.CompareTag("Wall"))
        {
            Destroy(this.gameObject, 5f);
        }
        if (other.CompareTag("Ceiling"))
        {
            Destroy(this.gameObject, 5f);
        }
    }
}
