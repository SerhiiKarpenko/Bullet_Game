using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _lampPrefab;

    private float _timeBeforeStartSpawning = 6f;
    private float _timeBetweenLSpawning = 0;

    private List<GameObject> lamps = new List<GameObject>();

    GameObject Player;
    float WhereToSpawn = 0;


    void Start()
    {
        Player = GameObject.Find("Player 1(Clone)");
        StartCoroutine(lampSpawner());
     
    }

    IEnumerator lampSpawner()
    {
        yield return new WaitForSeconds(_timeBeforeStartSpawning);
        while(true)
        {
            if(Player != null)
            {
                _timeBetweenLSpawning = Random.Range(4, 8);
                WhereToSpawn = Random.Range(Player.transform.position.x + 15, Player.transform.position.x + 25);
                Instantiate(_lampPrefab, new Vector3(WhereToSpawn, -0.08f, 0), Quaternion.identity);
                yield return new WaitForSeconds(_timeBetweenLSpawning);
            }
            else
            {
                Player = GameObject.Find("Player 1(Clone)");
                _timeBetweenLSpawning = Random.Range(4, 8);
                WhereToSpawn = Random.Range(Player.transform.position.x + 15, Player.transform.position.x + 25);
                Instantiate(_lampPrefab, new Vector3(WhereToSpawn, -0.08f, 0), Quaternion.identity);
                yield return new WaitForSeconds(_timeBetweenLSpawning);
            }
        }

    }

    
    
}
