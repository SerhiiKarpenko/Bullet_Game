using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleAndShelfScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Glass" || collision.name == "Glass(Clone)" || collision.name == "obstacle(Clone)" || collision.name == "obstacle2(Clone)")
        {
            Debug.Log("COLLISION");
            Transform transform = gameObject.GetComponentInParent<Transform>();
            if(transform == gameObject.GetComponentInParent<Transform>())
            {
                Debug.Log("hello");
            }

            
        }
    }


}
