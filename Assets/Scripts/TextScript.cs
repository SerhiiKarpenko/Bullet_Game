using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    GameObject _player;
    public Text text;
    int a;

    void Start()
    {
        StartCoroutine(find());
    }

    // Update is called once per frame
    void Update()
    {
        if (_player != null)
        {
            text.text = "Score " + _player.gameObject.GetComponent<PlayerController>().getPoints().ToString();
        }
        else
        {
            text.text = "Score " + 0;
        }
    }


   IEnumerator find()
    {
        yield return new WaitForSeconds(3f);
        _player = GameObject.Find("Player 1(Clone)");
        
    }


}
