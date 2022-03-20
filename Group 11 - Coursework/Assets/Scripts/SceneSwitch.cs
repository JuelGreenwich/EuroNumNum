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
    public GameObject enterStandPanelShop;

    //Panels activate
    public bool activateBelgiumPanel;
    public bool activateSlovakiaPanel;
    public bool activateDenmarkPanel;
    public bool activateSpainPanel;
    public bool activateShopPanel;

    public bool wentToShop;

    void Start()
    {
        enterStandPanelBelgium.SetActive(false);
        enterStandPanelSlovakia.SetActive(false);
        enterStandPanelDenmark.SetActive(false);
        enterStandPanelSpain.SetActive(false);
        enterStandPanelShop.SetActive(false);

        activateBelgiumPanel = true;
        activateSlovakiaPanel = true;
        activateDenmarkPanel = true;
        activateSpainPanel = true;
        activateShopPanel = true;

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
        print(wentToShop);
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

            if (StandsScript.canEnterShop == false)
            {
                activateShopPanel = false;
                wentToShop = true;
            }
            else
            {
                wentToShop = false;
            }
        }

        //Belgium
        if (hasPlayer == true && activateBelgiumPanel == true && gameObject.name == "Belgium" && wentToShop == true)
        {
            //print("belgium panel");
            enterStandPanelBelgium.SetActive(true);
            Belgium();
        }
        else
        {
            enterStandPanelBelgium.SetActive(false);
        }

        //Slovakia
        if (hasPlayer == true && activateSlovakiaPanel == true && gameObject.name == "Slovakia" && wentToShop == true)
        {
            //print("slovakia panel");
            enterStandPanelSlovakia.SetActive(true);
            Slovakia();

        }
        else
        {
            enterStandPanelSlovakia.SetActive(false);
        }

        //Denmark
        if (hasPlayer == true && activateDenmarkPanel == true && gameObject.name == "Denmark" && wentToShop == true)
        {
            //print("slovakia panel");
            enterStandPanelDenmark.SetActive(true);
            Denmark();
        }
        else
        {
            enterStandPanelDenmark.SetActive(false);
        }

        //Spain
        if (hasPlayer == true && activateSpainPanel == true && gameObject.name == "Spain" && wentToShop == true)
        {
            //print("slovakia panel");
            enterStandPanelSpain.SetActive(true);
            Spain();
        }
        else
        {
            enterStandPanelSpain.SetActive(false);
        }

        //Shop
        if (hasPlayer == true && activateShopPanel == true && gameObject.name == "Shop")
        {
            //print("shop panel");
            enterStandPanelShop.SetActive(true);
            Shop();
        }
        else
        {
            enterStandPanelShop.SetActive(false);
        }
    }

    void EnterScene()
    {
        SceneManager.LoadScene(sceneName);
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

    void Shop()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (GameObject.FindGameObjectWithTag("Save") == null)
            {
                EnterScene();
            }
            else if (StandsScript.canEnterShop == true)
            {
                EnterScene();
            }
        }
    }
}
