using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletSpawnersScript : MonoBehaviour
{
    [SerializeField] private List<GameObject> _spawnersList;
    [SerializeField] private GameObject _enemyBulletPrefab;
    [SerializeField] private float _timeBetweenBulletsAppearing = 7f;
    [SerializeField] private float _timeToHardUp = 15f;
    [SerializeField] private float _timeBeforeFirstBullet = 3.5f;
    

    
    // может быть сделанно так что тут не список объектов, а три переменные трансформ и брать им вектор позиции.
   
    int whichSpawner = 0;
    
    void Start()
    {
        StartCoroutine(Spawn());
    }


    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(_timeBeforeFirstBullet);
        while (true)
        {

            whichSpawner = Random.Range(0, 3);
            Debug.Log(whichSpawner);
            Instantiate(_enemyBulletPrefab, _spawnersList[whichSpawner].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(_timeBetweenBulletsAppearing);
        }

    }

    public void SetTimeBetweenBulletAppearing(float time)
    {
        _timeBetweenBulletsAppearing = time;
    }

    // getters
    public float GetTimeBetweenBulletAppearing()
    {
        return _timeBetweenBulletsAppearing;
    }

    public float GetTimeToHardUp()
    {
        return _timeToHardUp;
    }
}
