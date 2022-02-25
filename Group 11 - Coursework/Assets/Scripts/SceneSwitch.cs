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

    void Start()
    {
        sceneSwitch = this;
        sceneSwitch.enterStandPanel.SetActive(false);
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
        if (hasPlayer)
        {
            sceneSwitch.enterStandPanel.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Return))
            {
            SceneManager.LoadScene(sceneName);
            sceneSwitch.enterStandPanel.SetActive(false);
            }

        }
        else
        {
            sceneSwitch.enterStandPanel.SetActive(false);
        }
    }

}
