using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    GameManagerScript gameManager;

    [SerializeField] GameObject goToPanel;
    [SerializeField] GameObject GoToShopPanel;

    [SerializeField] SceneSwitch SceneSwitchScript;

    public bool closePanel;
    // Start is called before the first frame update
    void Start()
    {

        Time.timeScale = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        if(goToPanel == null)
        {
            goToPanel = GameObject.FindGameObjectWithTag("Panel");
        }


        if (SceneSwitchScript != null)
        {
            if (SceneSwitchScript.activateShopPanel == true) //Shop Panel
            {
                    GoToShopPanel.SetActive(true);
                    goToPanel.SetActive(false);
            }
            else //Stand panel
            {
                if (closePanel == false) 
                {
                    goToPanel.SetActive(true);
                    GoToShopPanel.SetActive(false);
                }
                else
                {
                    goToPanel.SetActive(false);
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            goToPanel.SetActive(false);
            Time.timeScale = 1f;

            closePanel = true;
        }

    }


    void LoadScene()
    {

    }
}
