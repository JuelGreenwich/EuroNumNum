using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    [SerializeField] GameObject CreditsPanel;

    private void Start()
    {
        if (CreditsPanel != null)
        {
            CreditsPanel.SetActive(false);
        }
    }

    public void LoadScene(string s)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(s);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void OpenCredits()
    {
        if(CreditsPanel != null)
        {
            CreditsPanel.SetActive(true);
        }
    }

    public void CloseExitPanel()
    {
        if (CreditsPanel != null)
        {
            CreditsPanel.SetActive(false);
        }
    }
}
