using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public string sceneName;
    public bool hasPlayer;

    //public static SceneSwitch sceneSwitch;

    public StandsManager StandsScript;

    //Panels GameObjects
    public GameObject enterStandPanelBelgium;
    public GameObject enterStandPanelSlovakia;
    public GameObject enterStandPanelDenmark;
    public GameObject enterStandPanelSpain;

    //Panels activate
    public bool activateBelgiumPanel;
    public bool activateSlovakiaPanel;
    public bool activateDenmarkPanel;
    public bool activateSpainPanel;


    void Start()
    {
            enterStandPanelBelgium.SetActive(false);
            enterStandPanelSlovakia.SetActive(false);
            enterStandPanelDenmark.SetActive(false);
            enterStandPanelSpain.SetActive(false);

        activateBelgiumPanel = true;
        activateSlovakiaPanel = true;
        activateDenmarkPanel = true;
        activateSpainPanel = true;
    }
    void OnTriggerEnter(Collider other)
    {
        hasPlayer = true;
    }

    private void OnTriggerExit(Collider other)
    {
        hasPlayer = false;    
    }

    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Save") != null)
        {
            //get the Stands Manager reference
            StandsScript = GameObject.FindGameObjectWithTag("Save").GetComponent<StandsManager>();

            //Check panels
            if(StandsScript.canEnterBelgium == false)
            {
                activateBelgiumPanel = false;
            }

            if (StandsScript.canEnterSlovakia == false)
            {
                activateSlovakiaPanel = false;
            }

            if (StandsScript.canEnterDenmark == false)
            {
                activateDenmarkPanel = false;
            }

            if (StandsScript.canEnterSpain == false)
            {
                activateSpainPanel = false; 
            }

        }
        //Belgium
        if (hasPlayer == true && activateBelgiumPanel == true && gameObject.name == "Belgium")
        {
            print("belgium panel");
            //sceneSwitch.
            enterStandPanelBelgium.SetActive(true);
            Belgium();
        }
        else
        {
            //sceneSwitch.
                enterStandPanelBelgium.SetActive(false);
        }

        //Slovakia
        if (hasPlayer == true && activateSlovakiaPanel == true && gameObject.name == "Slovakia")
        {
            print("slovakia panel");
            enterStandPanelSlovakia.SetActive(true);
            Slovakia();

        }
        else
        {
            enterStandPanelSlovakia.SetActive(false);
        }

        //Denmark
        if (hasPlayer == true && activateDenmarkPanel == true && gameObject.name == "Denmark")
        {
            print("slovakia panel");
            enterStandPanelDenmark.SetActive(true);
            Denmark();
        }
        else
        {
            enterStandPanelDenmark.SetActive(false);
        }

        //Spain
        if (hasPlayer == true && activateSpainPanel == true && gameObject.name == "Spain")
        {
            print("slovakia panel");
            enterStandPanelSpain.SetActive(true);
            Denmark();
        }
        else
        {
            enterStandPanelSpain.SetActive(false);
        }


    }

    void EnterScene()
    {
        SceneManager.LoadScene(sceneName);
        //sceneSwitch.
            enterStandPanelBelgium.SetActive(false);
    }

    void BackToLobby()
    {
        SceneManager.LoadScene("MainLobby");
    }

    void Belgium()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (GameObject.FindGameObjectWithTag("Save") == null) //beginning when the BelgiumDD does not exist 
            {
                EnterScene();
            }
            else if (StandsScript.canEnterBelgium == true) 
            {
                EnterScene();
            } //else you don't enter scene
        }
    }

    void Slovakia()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (GameObject.FindGameObjectWithTag("Save") == null)
            {
                EnterScene();
            }
            else if (StandsScript.canEnterSlovakia == true)
            {
                EnterScene();
            }
        }
    }

    void Denmark()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (GameObject.FindGameObjectWithTag("Save") == null)
            {
                EnterScene();
            }
            else if (StandsScript.canEnterDenmark == true)
            {
                EnterScene();
            }
        }
    }

    void Spain()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (GameObject.FindGameObjectWithTag("Save") == null)
            {
                EnterScene();
            }
            else if (StandsScript.canEnterSpain == true)
            {
                EnterScene();
            }
        }
    }
}
