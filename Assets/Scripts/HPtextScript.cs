using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPtextScript : MonoBehaviour
{
    GameObject _player;
    public Text text;

    void Start()
    {
        StartCoroutine(find());
    }

    // Update is called once per frame
    void Update()
    {
        if (_player != null)
        {
            text.text = "HP " + _player.gameObject.GetComponent<PlayerController>().getHp().ToString();
        }
        else
        {
            text.text = "HP " + 3;
        }
    }


    IEnumerator find()
    {
        yield return new WaitForSeconds(3f);
        _player = GameObject.Find("Player 1(Clone)");

    }

}
