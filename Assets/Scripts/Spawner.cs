using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private GameObject _bulletPrefab;
    private float _spawnTime = 2f;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(_spawnTime);
        Instantiate(_bulletPrefab, _spawnPoint.position, Quaternion.identity);
    }

   
}
