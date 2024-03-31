using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyShoot : MonoBehaviour
{
    public GameObject bullet;
    public GameObject enemyBulletSpawn;
    public GameObject enemyBulletSpawnDirection;
    public bool cooldown = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(cooldown);
        if (!cooldown)
        {
            if (Vector3.Distance(this.GetComponent<Transform>().position, GameObject.FindGameObjectWithTag("Player").transform.position) <= this.GetComponent<NavMeshAgent>().stoppingDistance)
            {
                StartCoroutine("bulletFlying");
            }
        }
    }

    IEnumerator bulletFlying()
    {
        cooldown = true;
        GameObject theBullet = Instantiate(bullet, enemyBulletSpawn.transform.position, enemyBulletSpawn.transform.rotation);
        theBullet.GetComponent<Rigidbody>().velocity = 25 * (enemyBulletSpawnDirection.transform.position - enemyBulletSpawn.transform.position).normalized;
        StartCoroutine("coolDownRegained");
        yield return null;
    }

    IEnumerator coolDownRegained()
    {
        yield return new WaitForSeconds(2);
        cooldown = false;
    }
}
