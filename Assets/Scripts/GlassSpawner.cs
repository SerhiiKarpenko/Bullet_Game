using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _glassPrefab;
 
    private float _timeBeforeStartSpawn = 6;
    private float _timeBetweenGlassSpawn = 0;

    GameObject Player;

    float WhereToSpawn;
    
    


    void Start()
    {
        Player = GameObject.Find("Player 1(Clone)");
        StartCoroutine(spawnGlass());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnGlass()
    {
        yield return new WaitForSeconds(_timeBeforeStartSpawn);


        while(true)
        {
            if(Player != null)
            {
                _timeBetweenGlassSpawn = Random.Range(3f, 9f);
                WhereToSpawn = Random.Range(15f, 25f);
                Instantiate(_glassPrefab, new Vector3(Player.transform.position.x + WhereToSpawn, -3.401582f, 0), Quaternion.identity);
                yield return new WaitForSeconds(_timeBetweenGlassSpawn);
            }
            else
            {
                Player = GameObject.Find("Player 1(Clone)");
                _timeBetweenGlassSpawn = Random.Range(3f, 9f);
                WhereToSpawn = Random.Range(15f, 25f);
                Instantiate(_glassPrefab, new Vector3(Player.transform.position.x + WhereToSpawn, -3.401582f, 0), Quaternion.identity);
                yield return new WaitForSeconds(_timeBetweenGlassSpawn);

            }

        }
    }
}
