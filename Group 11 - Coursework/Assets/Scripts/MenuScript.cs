using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void LoadScene(string s)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(s);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
