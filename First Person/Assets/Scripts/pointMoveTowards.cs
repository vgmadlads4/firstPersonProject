using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointMoveTowards : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit target;
            if(Physics.Raycast(GameObject.FindWithTag("MainCamera").GetComponent<Camera>().ScreenPointToRay(Input.mousePosition),out target))
            {
                GameObject.FindWithTag("Player").transform.LookAt(target.point);
                GameObject.FindWithTag("Player").transform.Translate(Vector3.forward);
                //GameObject.FindWithTag("Player").transform.position = target.point;
            }
        }
    }
}
