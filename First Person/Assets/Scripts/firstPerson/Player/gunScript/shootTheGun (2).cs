using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootTheGun : MonoBehaviour
{
    public GameObject bullet;
    private bool hasBeenFired = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !hasBeenFired)
        {
            StartCoroutine("bulletFlying");
        }
    }

    IEnumerator bulletFlying()
    {
        GameObject theBullet = Instantiate(bullet, GameObject.Find("bulletSpawn").transform.position, GameObject.Find("bulletSpawn").transform.rotation);
        theBullet.GetComponent<Rigidbody>().velocity = 25 * (GameObject.Find("bulletSpawn").transform.position - GameObject.Find("bulletDirection").transform.position).normalized;
        yield return null;
    }

}
