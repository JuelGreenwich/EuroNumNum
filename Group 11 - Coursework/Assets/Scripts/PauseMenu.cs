using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    //Apply Script to the canvas.
    public static bool GameIsPasued = false;
    public string sceneName; //UI Refrence. This is an Pannel, with the buttons on it.

    public GameObject exitPannel;
    public GameObject resumePannel;
    public GameObject startPannel;
    public GameObject pauseMenuUI;

    void Awake()
    {
        startPannel.SetActive(true);
        Time.timeScale = 0f;
        GameIsPasued = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPasued)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void ExitPanne()
    {
        exitPannel.SetActive(true);
    }

    public void ResumePannel()
    {
        resumePannel.SetActive(true);
    }

    public void Resume()
    {
        //The timescale is set to 1 to unfreeze time.
        pauseMenuUI.SetActive(false);
        resumePannel.SetActive(false);
        startPannel.SetActive(false);
       
        Time.timeScale = 1f;
        GameIsPasued = false;
    }
    void Pause()
    {
        //The timescale is set to 0 to freeze time.
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPasued = true;
    }

    //On each of the buttons, there is an onclick event, we add an event, drag the canvas into the "none (object)" under the pause menu script there is a resume
    public void LoadToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName);
    }


    //If we need to Quit the game, uncomment the Application.quite if needed.
    public void QuitGame()
    {
        Debug.Log("Quitting Game");
        //Application.Quit();
    }

    //This is for the Pasue button.
    public void PauseTheGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPasued = true;
        Debug.Log("Pasued");
        //Pause();
    }

    public void ResumeFromExitPannel()
    {
        exitPannel.SetActive(false);
        Time.timeScale = 1f;
        GameIsPasued = false;
    }
}