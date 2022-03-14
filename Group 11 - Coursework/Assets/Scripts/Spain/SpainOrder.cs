using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpainOrder : MonoBehaviour
{
    DragAndDropNEW DnDScript;
    int counter = 1;
    [SerializeField] CounterOrderIngredients CounterScript;

    XCross XCrossScript;

    // Start is called before the first frame update
    void Start()
    {
        DnDScript = gameObject.GetComponent<DragAndDropNEW>();
        XCrossScript = gameObject.GetComponent<XCross>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CounterScript.counter == 1)
        {
            ActivateDragAndDrop("Chicken");
        }
        if (CounterScript.counter == 2)
        {
            ActivateDragAndDrop("Saffron");

            CrossFirstStep(2); //cross first step
        }
        if (CounterScript.counter == 3)
        {
            ActivateDragAndDrop("Oil");

            CrossSecondStep(3); //cross second step
        }
        if (CounterScript.counter == 4) //Onion
        {
            ActivateDragAndDrop("Knife");
            ActivateDragAndDrop("Onion");
            ActivateDragAndDrop("OnionCut");

            ChangeFirstList(4); //change list
        }
        if (CounterScript.counter == 5) //Pepper
        {
            ActivateDragAndDrop("Pepper");
            ActivateDragAndDrop("PepperCut");
        }
        if (CounterScript.counter == 6) //Garlic
        {
            ActivateDragAndDrop("Garlic");
            ActivateDragAndDrop("GarlicCut");

            CrossFirstStep(6);
        }
        if (CounterScript.counter == 7) //Sausage
        {
            ActivateDragAndDrop("Sausage");
            ActivateDragAndDrop("SausageCut");
        }
        if (CounterScript.counter == 8) 
        {
            ActivateDragAndDrop("BombaRice");

            CrossSecondStep(8);
        }
        if (CounterScript.counter == 9) //Tomato
        {
            ActivateDragAndDrop("Tomato");
            ActivateDragAndDrop("TomatoCut");

            ChangeSecondList(9);
        }
        if (CounterScript.counter == 10) 
        {
            ActivateDragAndDrop("SaucePan");
        }
        if (CounterScript.counter == 11)
        {
            ActivateDragAndDrop("Mussles");
        }
        if (CounterScript.counter == 12)
        {
            ActivateDragAndDrop("Shrimp");
        }
        if (CounterScript.counter == 13)
        {
            ActivateDragAndDrop("Peas");
        }
        if (CounterScript.counter == 14)
        {
            ActivateDragAndDrop("Salt");

            CrossFirstStep(14);
        }
        if (CounterScript.counter == 15) //Pasley
        {
            ActivateDragAndDrop("Pasley");
            ActivateDragAndDrop("PasleyCut");

            CrossSecondStep(15);
        }
        if (CounterScript.counter == 16) 
        {
            CrossThirdStep(16);
        }

    }

    void ActivateDragAndDrop(string s)
    {
        if (gameObject.name == s)
            DnDScript.enabled = true;
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

    void ChangeSecondList(int nr)
    {
        if (XCrossScript != null)
        {
            XCrossScript.changeList2 = nr;
        }
    }
}
