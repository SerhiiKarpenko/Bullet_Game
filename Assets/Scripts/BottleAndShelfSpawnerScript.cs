using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleAndShelfSpawnerScript : MonoBehaviour
{
    [SerializeField] private GameObject _bottleAndShelfPrefab;
    [SerializeField] private float _timeBeforeStartSpawning = 7f;
    [SerializeField] private float _timeBetweenSpawning;


    GameObject Player;
    float WhereToSpawn;
    float PosY;

    void Start()
    {
        Player = GameObject.Find("Player 1(Clone)");
        StartCoroutine(startSpawn());
    }
    
    IEnumerator startSpawn()
    {
        yield return new WaitForSeconds(_timeBeforeStartSpawning);
        while (true)
        {
            if (Player != null)
            {
                _timeBetweenSpawning = Random.Range(4, 9);
                WhereToSpawn = Random.Range(Player.transform.position.x + 13, Player.transform.position.x + 23);
                PosY = Random.Range(-5.53f, 0.2f);
                Instantiate(_bottleAndShelfPrefab, new Vector3(WhereToSpawn, PosY, 0), Quaternion.identity);
                yield return new WaitForSeconds(_timeBetweenSpawning);

            }
            else
            {
                Player = GameObject.Find("Player 1(Clone)");
                _timeBetweenSpawning = Random.Range(4, 9);
                if (Player != null)
                {
                    WhereToSpawn = Random.Range(Player.transform.position.x + 13, Player.transform.position.x + 23);
                }
                PosY = Random.Range(-5.53f, 0.2f);
                Instantiate(_bottleAndShelfPrefab, new Vector3(WhereToSpawn, PosY, 0), Quaternion.identity);
                yield return new WaitForSeconds(_timeBetweenSpawning);
            }
        }
    }
}
