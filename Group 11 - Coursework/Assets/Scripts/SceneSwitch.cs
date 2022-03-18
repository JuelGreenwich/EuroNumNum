using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public string sceneName;
    public bool hasPlayer;
    public GameObject enterStandPanel;
    public static SceneSwitch sceneSwitch;
    public GameObject BelgiumDD;

    public StandsManager StandsScript;


    void Start()
    {
        sceneSwitch = this;
        sceneSwitch.enterStandPanel.SetActive(false);
        //StandsScript = GameObject.FindGameObjectWithTag("Save").GetComponent<StandsManager>();
        //BelgiumDD = GameObject.FindGameObjectWithTag("Save");
    }
    void OnTriggerEnter(Collider other)
    {
        //if (other.CompareTag("Player"))
        //{
            hasPlayer = true;
        //}
        //SceneManager.LoadScene(sceneName);
    }

    private void OnTriggerExit(Collider other)
    {
        hasPlayer = false;    
    }

    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Save") != null)
        {
            StandsScript = GameObject.FindGameObjectWithTag("Save").GetComponent<StandsManager>();
        }
        if (hasPlayer)
        {
            sceneSwitch.enterStandPanel.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Return))
            {
                if(GameObject.FindGameObjectWithTag("Save") == null)
                {
                    EnterScene();
                }
                else if (StandsScript.canEnterBelgium == true)
                {
                    EnterScene();
                }
                else
                {
                    sceneSwitch.enterStandPanel.SetActive(false);
                }
            }

        }
        else
        {
            sceneSwitch.enterStandPanel.SetActive(false);
        }
    }

    void EnterScene()
    {
        SceneManager.LoadScene(sceneName);
        sceneSwitch.enterStandPanel.SetActive(false);
        //StandsScript.canEnterBelgium = false;
        //sceneName = "abc";
    }

    void BackToLobby()
    {
        SceneManager.LoadScene("MainLobby");
    }

}
