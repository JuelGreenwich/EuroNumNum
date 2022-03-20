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
        ColliderObj.enabled = false;


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

        //Belgium
        if (CounterScript.counter == 6)
        {
            ActivateDragAndDrop("Flour");

            ResetX();
        }
        if (CounterScript.counter == 7)
        {
            ActivateDragAndDrop("BPowder");

            X[0].enabled = true;
        }
        if (CounterScript.counter == 8)
        {
            ActivateDragAndDrop("Sugar");

            X[1].enabled = true;
        }
        if (CounterScript.counter == 9)
        {
            ActivateDragAndDrop("Milk");

            X[2].enabled = true;
        }
        if (CounterScript.counter == 10)
        {
            ActivateDragAndDrop("Eggs1");

            X[3].enabled = true;
        }
        if (CounterScript.counter == 11)
        {
            ActivateDragAndDrop("Butter");

            X[4].enabled = true;
        }
        if (CounterScript.counter == 12)
        {
            ActivateDragAndDrop("Vanilla");

            X[5].enabled = true;
        }

        //Slovakia
        if (CounterScript.counter == 13)
        {
            ActivateDragAndDrop("Meat");

            ResetX();
        }
        if (CounterScript.counter == 14)
        {
            ActivateDragAndDrop("Rice");

            X[0].enabled = true;
        }
        if (CounterScript.counter == 15)
        {
            ActivateDragAndDrop("Onion");

            X[1].enabled = true;
        }
        if (CounterScript.counter == 16)
        {
            ActivateDragAndDrop("Eggs2");

            X[2].enabled = true;
        }
        if (CounterScript.counter == 17)
        {
            ActivateDragAndDrop("Garlic");

            X[3].enabled = true;
        }
        if (CounterScript.counter == 18)
        {
            ActivateDragAndDrop("TomatoSauce");

            X[4].enabled = true;
        }
        if (CounterScript.counter == 19)
        {
            ActivateDragAndDrop("Oil");

            X[5].enabled = true;
        }

        //Spain
        if (CounterScript.counter == 20)
        {
            ActivateDragAndDrop("Stock");

            ResetX();
        }
        if (CounterScript.counter == 21)
        {
            ActivateDragAndDrop("Saffron");

            X[0].enabled = true;
        }
        if (CounterScript.counter == 22)
        {
            ActivateDragAndDrop("Mussels");

            X[1].enabled = true;
        }
        if (CounterScript.counter == 23)
        {
            ActivateDragAndDrop("Tomato");

            X[2].enabled = true;
        }
        if (CounterScript.counter == 24)
        {
            ActivateDragAndDrop("Pepper");

            X[3].enabled = true;
        }
        if (CounterScript.counter == 25)
        {
            ActivateDragAndDrop("Sausage");

            X[4].enabled = true;
        }
        if (CounterScript.counter == 26)
        {
            ActivateDragAndDrop("BombaRice");

            X[5].enabled = true;
        }
        if (CounterScript.counter == 27)
        {
            ActivateDragAndDrop("Parsley");

            X[6].enabled = true;
        }
        if (CounterScript.counter == 28)
        {
            ActivateDragAndDrop("Peas");

            X[7].enabled = true;
        }
        if (CounterScript.counter == 29)
        {
            ActivateDragAndDrop("Shrimp");

            X[8].enabled = true;
        }
        if (CounterScript.counter == 30)
        {
            X[9].enabled = true;

            Invoke("BackToLobby", 2f);
        }
    }

    void ActivateDragAndDrop(string s)
    {
        if (gameObject.name == s)
        {
            DnDScript.enabled = true;
            ColliderObj.enabled = true;
        }
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
