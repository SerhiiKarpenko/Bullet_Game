using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _speed = 3f;
    [SerializeField] private int _damage = 1;

    float timeOfLife = 10f;

    void Start()
    {
        Destroy(gameObject, timeOfLife);
        _rb = GetComponent<Rigidbody2D>();
    }

   
    void FixedUpdate()
    {
        _rb.transform.position += new Vector3(-1, 0, 0) * _speed * Time.fixedDeltaTime;
    }


    private void OnTriggerEnter2D(Collider2D whatIamHitting)
    {
        PlayerController player = whatIamHitting.GetComponent<PlayerController>();
        if(player != null)
        {
            player.takeDamage(_damage);
            Destroy(gameObject);
        }
    }
}
