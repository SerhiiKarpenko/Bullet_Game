using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backGround : MonoBehaviour
{
    [SerializeField] private float _timeToDestroy = 15f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, _timeToDestroy);
    }

    // Update is called once per frame
    
}
