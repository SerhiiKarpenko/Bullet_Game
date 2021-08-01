using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glass : MonoBehaviour
{

    float PosX;
    float TimeOfLife = 10f;

    void Start()
    {
       PosX = transform.position.x;
       Destroy(gameObject, TimeOfLife);
    }

    



}
