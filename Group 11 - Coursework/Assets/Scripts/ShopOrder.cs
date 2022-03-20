using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShopOrder : MonoBehaviour
{
    DragAndDropNEW DnDScript;
    [SerializeField] CounterOrderIngredients CounterScript;
    [SerializeField] Collider ColliderObj;

    XCross XCrossScript;

    [SerializeField] GameObject DonePanel;
    [SerializeField] Image[] X;

    // Start is called before the first frame update
    void Start()
    {
        DnDScript = gameObject.GetComponent<DragAndDropNEW>();
        XCrossScript = gameObject.GetComponent<XCross>();
        ColliderObj = gameObject.GetComponent<Collider>();


        for(int i=0; i<X.Length; i++)
        {
            X[i].enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Denmark
        if (CounterScript.counter == 1)
        {
            ActivateDragAndDrop("Bread");
        }
        if (CounterScript.counter == 2)
        {
            ActivateDragAndDrop("Mayo");

            X[0].enabled = true;
        }
        if (CounterScript.counter == 3)
        {
            ActivateDragAndDrop("Salmon");

            X[1].enabled = true;
        }
        if (CounterScript.counter == 4) //CUCUMBER
        {
            ActivateDragAndDrop("Cucumber");

            X[2].enabled = true;
        }
        if (CounterScript.counter == 5) //ONION
        {
            ActivateDragAndDrop("SpringOnion");

            X[3].enabled = true;
        }
        if (CounterScript.counter == 6)
        {
            X[4].enabled = true;
        }

        //Belgium
        if (CounterScript.counter == 7)
        {
            ActivateDragAndDrop("Flour");

            ResetX();
        }
        if (CounterScript.counter == 8)
        {
            ActivateDragAndDrop("BPowder");

            X[0].enabled = true;
        }
        if (CounterScript.counter == 9)
        {
            ActivateDragAndDrop("Sugar");

            X[1].enabled = true;
        }
        if (CounterScript.counter == 10)
        {
            ActivateDragAndDrop("Milk");

            X[2].enabled = true;
        }
        if (CounterScript.counter == 11)
        {
            ActivateDragAndDrop("Eggs");

            X[3].enabled = true;
        }
        if (CounterScript.counter == 12)
        {
            ActivateDragAndDrop("Butter");

            X[4].enabled = true;
        }
        if (CounterScript.counter == 13)
        {
            ActivateDragAndDrop("Vanilla");

            X[5].enabled = true;
        }
        if (CounterScript.counter == 14)
        {
            X[6].enabled = true;
        }

        //Slovakia
        if (CounterScript.counter == 15)
        {
            ActivateDragAndDrop("Meat");

            ResetX();
        }
        if (CounterScript.counter == 16)
        {
            ActivateDragAndDrop("Rice");

            X[0].enabled = true;
        }
        if (CounterScript.counter == 17)
        {
            ActivateDragAndDrop("Onion");

            X[1].enabled = true;
        }
        if (CounterScript.counter == 18)
        {
            ActivateDragAndDrop("Eggs");

            X[2].enabled = true;
        }
        if (CounterScript.counter == 19)
        {
            ActivateDragAndDrop("Garlic");

            X[3].enabled = true;
        }
        if (CounterScript.counter == 20)
        {
            ActivateDragAndDrop("TomatoSauce");

            X[4].enabled = true;
        }
        if (CounterScript.counter == 21)
        {
            ActivateDragAndDrop("Oil");

            X[5].enabled = true;
        }
        if (CounterScript.counter == 22)
        {
            X[6].enabled = true;
        }

        //Spain
        if (CounterScript.counter == 23)
        {
            ActivateDragAndDrop("Stock");

            ResetX();
        }
        if (CounterScript.counter == 24)
        {
            ActivateDragAndDrop("Saffron");

            X[0].enabled = true;
        }
        if (CounterScript.counter == 25)
        {
            ActivateDragAndDrop("Garlic");

            X[1].enabled = true;
        }
        if (CounterScript.counter == 26)
        {
            ActivateDragAndDrop("Tomato");

            X[2].enabled = true;
        }
        if (CounterScript.counter == 27)
        {
            ActivateDragAndDrop("Pepper");

            X[3].enabled = true;
        }
        if (CounterScript.counter == 28)
        {
            ActivateDragAndDrop("Sausage");

            X[4].enabled = true;
        }
        if (CounterScript.counter == 29)
        {
            ActivateDragAndDrop("BombaRice");

            X[5].enabled = true;
        }
        if (CounterScript.counter == 30)
        {
            ActivateDragAndDrop("Parsley");

            X[6].enabled = true;
        }
        if (CounterScript.counter == 31)
        {
            ActivateDragAndDrop("Peas");

            X[7].enabled = true;
        }
        if (CounterScript.counter == 32)
        {
            ActivateDragAndDrop("Shrimp");
            ActivateDragAndDrop("Mussels");

            X[8].enabled = true;
        }
        if (CounterScript.counter == 33)
        {
            X[9].enabled = true;
        }

        if (CounterScript.counter == 14)
        {
            CrossThirdStep(8);
            Invoke("ActivateDonePanel", 2f);
            //Invoke("BackToLobby", 5f);
        }
    }

    void ActivateDragAndDrop(string s)
    {
        if (gameObject.name == s)
            DnDScript.enabled = true;

        ColliderObj.enabled = true;
    }

    void CrossFirstStep(int nr)
    {
        if (XCrossScript != null)
        {
            XCrossScript.stepX1isCrossed = nr;
        }
    }

    void CrossSecondStep(int nr)
    {
        if (XCrossScript != null)
        {
            XCrossScript.stepX2isCrossed = nr;
        }
    }

    void CrossThirdStep(int nr)
    {
        if (XCrossScript != null)
        {
            XCrossScript.stepX3isCrossed = nr;
        }
    }

    void ChangeFirstList(int nr)
    {
        if (XCrossScript != null)
        {
            XCrossScript.changeList1 = nr;
        }
    }

    void ActivateDonePanel()
    {
        if (DonePanel != null)
        {
            DonePanel.SetActive(true);
        }
    }

    void BackToLobby()
    {
        SceneManager.LoadScene("MainLobby");
    }

    void ResetX()
    {
        for (int i = 0; i < X.Length; i++)
        {
            X[i].enabled = false;
        }
    }
}
