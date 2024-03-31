using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theBulletItselfReturning : MonoBehaviour
{
    bool turnAroundTrackDown = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("theBulletIsCurrentlyFlying");
    }

    // Update is called once per frame
    void Update()
    {
        if (turnAroundTrackDown)
        {
            this.gameObject.transform.LookAt(GameObject.Find("bulletSpawn").transform);
            this.gameObject.GetComponent<Rigidbody>().velocity = 25 * (GameObject.Find("bulletSpawn").transform.position - this.gameObject.transform.position).normalized;

        }
    }


    IEnumerator theBulletIsCurrentlyFlying ()
    {
        GameObject.FindWithTag("playerGun").GetComponent<bulletReturn>().hasBeenFired = true;
        yield return new WaitForSeconds(10);
        turnAroundTrackDown = true;
        yield return new WaitForSeconds(10);

        //yield return new WaitForSeconds(60);
        //GameObject.FindWithTag("playerGun").GetComponent<bulletReturn>().hasBeenFired = false;
        //Destroy(this.gameObject);
    }
}
