using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampScript : MonoBehaviour
{

    float WiatForDestroing = 10f;

    void Start()
    {
        Destroy(gameObject, WiatForDestroing);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.name == "Glass" || hitInfo.name == "Glass(Clone)")
        {
            Debug.Log("COLLISION WITH GLASS -> LAMP");
            transform.Translate(Vector3.right * 5f);
        }
        
    }
}
