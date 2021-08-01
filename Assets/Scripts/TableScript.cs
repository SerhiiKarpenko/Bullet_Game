using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableScript : MonoBehaviour
{
    float WaitForDeleting = 15f;

    void Start()
    {
        Destroy(gameObject, WaitForDeleting);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if(hitInfo.name == "Glass" || hitInfo.name == "Glass(Clone)")
        {
            Debug.Log("COLLISION WITH GLASS -> TABLE");
            transform.Translate(Vector3.right * 5f);
        }
       
    }


}
