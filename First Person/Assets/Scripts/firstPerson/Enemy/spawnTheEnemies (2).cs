using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTheEnemies : MonoBehaviour
{
    public GameObject theEnemy;
    private bool spawnTimer;
    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Enemy").Length < 20 && spawnTimer)
        {
            Instantiate(theEnemy,this.transform.position, this.transform.rotation);
            spawnTimer = false;
            StartCoroutine(timerturnsTrue());
        }
    }

    public IEnumerator timerturnsTrue()
    {
        yield return new WaitForSeconds(5);
        spawnTimer = true;
    }
}
