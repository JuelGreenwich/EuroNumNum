using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlovakiaOrder : MonoBehaviour
{
    DragAndDropNEW DnDScript;
    int counter = 1;
    [SerializeField] CounterOrderIngredients CounterScript;
    [SerializeField] GameObject Mix;
    [SerializeField] BoxCollider BowlCollider;

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
        if (CounterScript.counter == 1) //Rice
        {
            ActivateDragAndDrop("Rice"); 
        }
        if (CounterScript.counter == 2) //Water
        {
            ActivateDragAndDrop("Water1"); 
        }
        if (CounterScript.counter == 3) //Meat + CHANGE POT 
        {
            ActivateDragAndDrop("Meat");

            CrossFirstStep(3); //cross first step
        }
        if (CounterScript.counter == 4) //Onion
        {
            ActivateDragAndDrop("Knife");
            ActivateDragAndDrop("Onion1");
            ActivateDragAndDrop("OnionCut1");

            CrossSecondStep(4); //cross second step
        }
        if (CounterScript.counter == 5) //Garlic
        {
            ActivateDragAndDrop("Garlic");
            ActivateDragAndDrop("GarlicCut");
        }
        if (CounterScript.counter == 6) //Eggs
        {
            ActivateDragAndDrop("Egg1");
            ActivateDragAndDrop("Egg2");

            ChangeFirstList(6); //change list
        }
        if (CounterScript.counter == 7) //SaucePan
        {
            ActivateDragAndDrop("SaucePan");

            CrossFirstStep(7);
        }
        if (CounterScript.counter == 8) //Salt
        {
            ActivateDragAndDrop("Salt");
        }
        if (CounterScript.counter == 9) //Pepper 
        {
            ActivateDragAndDrop("Pepper");
        }
        if (CounterScript.counter == 10) //Oil + CHANGE POT
        {
            ActivateDragAndDrop("Oil");
            //ActivateDragAndDrop("Bowl");

            if(Mix != null)
            {
                Mix.SetActive(true); //Make the Mix visible
            }

            CrossSecondStep(10);
        }
        if (CounterScript.counter == 11) //Onion2
        {
            ActivateDragAndDrop("Onion2");
            ActivateDragAndDrop("OnionCut2");
        }
        if (CounterScript.counter == 12) //Sauce
        {
            ActivateDragAndDrop("Sauce");

            ChangeSecondList(12);
        }
        if (CounterScript.counter == 13) //MixBowl to Board
        {
            ActivateDragAndDrop("Mix");
            ActivateDragAndDrop("Meatballs");
            //activate some hand

            //deactivate the collider of the bowl
            if (BowlCollider != null)
            {
                BowlCollider.enabled = false;
            }

            CrossFirstStep(13);

        }
        if (CounterScript.counter == 14) //Pasley
        {
            ActivateDragAndDrop("Water2");

            CrossSecondStep(14);
        }
        if (CounterScript.counter == 15) //Pasley
        {
            CrossThirdStep(15);
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
