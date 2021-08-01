using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hardUpScript : MonoBehaviour
{

    GameObject spawners;
    float time;
    float newTime = 0;

    void Start()
    {
        
        spawners = GameObject.Find("EnemyBulletSpawner");
        time = spawners.GetComponent<EnemyBulletSpawnersScript>().GetTimeToHardUp();
        StartCoroutine(HardUp());
    }


    IEnumerator HardUp()
    {
        yield return new WaitForSeconds(time);
       
        while (true)
        {
            newTime = spawners.GetComponent<EnemyBulletSpawnersScript>().GetTimeBetweenBulletAppearing();

            if (newTime == 1)
            {
                Debug.Log("STOPPED");
                yield break; 
            }

            spawners.GetComponent<EnemyBulletSpawnersScript>().SetTimeBetweenBulletAppearing(newTime - 0.5f);
            yield return new WaitForSeconds(time);
        }
    }

}
