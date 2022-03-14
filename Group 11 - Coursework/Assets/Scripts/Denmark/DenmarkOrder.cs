using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DenmarkOrder : MonoBehaviour
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
        if(CounterScript.counter == 1)
        {
            ActivateDragAndDrop("Bread");
        }
        if (CounterScript.counter == 2)
        {
            ActivateDragAndDrop("Mayo");

            CrossFirstStep(2); //cross first step
        }
        if (CounterScript.counter == 3)
        {
            ActivateDragAndDrop("Salmon");
        }
        if (CounterScript.counter == 4) //CUCUMBER
        {
            ActivateDragAndDrop("Knife");
            ActivateDragAndDrop("CucumberFull");
            ActivateDragAndDrop("Cucumber");

            CrossSecondStep(4); //cross second step
        }
        if (CounterScript.counter == 5) //ONION
        {
            ActivateDragAndDrop("OnionFull");
            ActivateDragAndDrop("Onion");

            ChangeFirstList(5); //change list
        }
        if (CounterScript.counter == 6) 
        {
            ActivateDragAndDrop("Pepper");

            CrossFirstStep(6);
        }
        if (CounterScript.counter == 7)
        {
            ActivateDragAndDrop("Lemon");

            CrossSecondStep(7);
        }
        if (CounterScript.counter == 8)
        {
            CrossThirdStep(8);
        }

    }

    void ActivateDragAndDrop(string s)
    {
        if(gameObject.name == s)
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
}
