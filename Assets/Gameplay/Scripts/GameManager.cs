using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        if (instance)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }
    public static void LoadScene(string newSceneName)
    {
        SceneManager.LoadScene(newSceneName);
    }
    public void Quit()
    {
        Application.Quit();
    }

    public static void Lose()
    {
        SceneManager.LoadScene("DeathScene");
    }
}
