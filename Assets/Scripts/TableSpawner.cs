using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// ���� ���������!
// ������ ����������� ������� ��������� � �������� �� ��������� �� ���� � ������� �� ������� ������ + 50 �� ������� ������ + 100 ����


public class TableSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _tablePrefab;
    [SerializeField] private GameObject _player;

    private float _timeBeforeStartSpawning = 5f;
    private float _timeBetweenTables = 0;

    GameObject player;
    float WhereToSpawn = 0f;

    void Start()
    {
        //_rb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player 1(Clone)");
        StartCoroutine(TableSpawn());
    }

    IEnumerator TableSpawn()
    {
        yield return new WaitForSeconds(_timeBeforeStartSpawning);
        while (true)
        {
            if (player != null)
            {
                _timeBetweenTables = Random.Range(5, 9);
                WhereToSpawn = Random.Range(player.transform.position.x + 10, player.transform.position.x + 20);
                Instantiate(_tablePrefab, new Vector3(WhereToSpawn, -2.67f, 0), Quaternion.identity);
                yield return new WaitForSeconds(_timeBetweenTables);
            }
            else
            {
                player = GameObject.Find("Player 1(Clone)");
                _timeBetweenTables = Random.Range(5, 9);
                WhereToSpawn = Random.Range(player.transform.position.x + 10, player.transform.position.x + 20);
                Instantiate(_tablePrefab, new Vector3(WhereToSpawn, -2.67f, 0), Quaternion.identity);
                yield return new WaitForSeconds(_timeBetweenTables);
            }
        }
    }
}

