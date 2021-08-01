using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject _player;

    void Start()
    {
        
    }
    
    void Update()
    {
        transform.position = new Vector3(_player.transform.position.x, 0, _player.transform.position.z);
    }
}
