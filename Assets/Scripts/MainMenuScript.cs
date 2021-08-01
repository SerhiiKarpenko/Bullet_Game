using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void startInfinityMode()
    {
        SceneManager.LoadScene("InfinityMode");
    }

    public void startTutorialMode()
    {
        SceneManager.LoadScene("FirstLevel");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Replay()
    {
        SceneManager.LoadScene("MainMenu");
    }

    
}
