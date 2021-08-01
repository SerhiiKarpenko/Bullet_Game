using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    float Speed = 4;
    private float _timeToHardUp = 15f;


    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        StartCoroutine(HardUp());
    }


    void FixedUpdate()
    {
        _rb.transform.position += new Vector3(1, 0, 0) * Speed * Time.fixedDeltaTime;
    }

    IEnumerator HardUp()
    {
        yield return new WaitForSeconds(_timeToHardUp);
        while (true)
        {
            Speed += 1;
            yield return new WaitForSeconds(_timeToHardUp);
        }
    }
}

