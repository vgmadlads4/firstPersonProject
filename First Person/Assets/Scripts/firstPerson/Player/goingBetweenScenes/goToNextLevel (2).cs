using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToNextLevel : MonoBehaviour
{
    public int levels = 1;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("levelTwo"))
        {
            DontDestroyOnLoad(this.gameObject);
            SceneManager.LoadScene("secondScene");
            this.gameObject.transform.position = GameObject.FindWithTag("playerSpawn").transform.position;
            levels++;
        }

        if (other.CompareTag("levelOne"))
        {
            DontDestroyOnLoad(this.gameObject);
            SceneManager.LoadScene("firstScene");
            this.gameObject.transform.position = GameObject.FindWithTag("playerSpawn").transform.position;
        }

    }

}
