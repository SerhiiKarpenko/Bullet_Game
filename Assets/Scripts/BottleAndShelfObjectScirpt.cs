using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleAndShelfObjectScirpt : MonoBehaviour
{
    private float _timeOfLife = 10f;


    void Start()
    {
        Destroy(gameObject, _timeOfLife);
    }

}
