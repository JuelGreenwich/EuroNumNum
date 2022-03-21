using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BelgiumOrder : MonoBehaviour
{
    DragAndDropNEW DnDScript;
    [SerializeField] CounterOrderIngredients CounterScript;
    XCross XCrossScript;

    [SerializeField] GameObject WMakerEmpty;
    [SerializeField] GameObject WMakerFull;
    [SerializeField] GameObject WMakerClosed;

    [SerializeField] GameObject DonePanel;

    void Start()
    {
        DnDScript = gameObject.GetComponent<DragAndDropNEW>();
        XCrossScript = gameObject.GetComponent<XCross>();

        if(WMakerFull != null)
        {
            WMakerFull.SetActive(false);
        }

        if (WMakerClosed != null)
        {
            WMakerClosed.SetActive(false);
        }

        if (DonePanel != null)
        {
            DonePanel.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (CounterScript.counter == 1) //Flour BOWL2
        {
            ActivateDragAndDrop("Flour");

        }
        if (CounterScript.counter == 2) //BPowder
        {
            ActivateDragAndDrop("BPowder");

            CrossFirstStep(2); //cross first step
        }
        if (CounterScript.counter == 3) //Sugar
        {
            ActivateDragAndDrop("Sugar");

            CrossSecondStep(3); //cross second step
        }
        if (CounterScript.counter == 4) //Salt
        {
            ActivateDragAndDrop("Salt");
        }
        if (CounterScript.counter == 5) //Milk + CHANGE TO BOWL 1 + List2
        {
            ActivateDragAndDrop("Milk");

            ChangeFirstList(5); //change list
        }
        if (CounterScript.counter == 6) //Eggs
        {
            ActivateDragAndDrop("Egg1");
            ActivateDragAndDrop("Egg2");

            CrossFirstStep(6);
        }
        if (CounterScript.counter == 7) //Butter
        {
            ActivateDragAndDrop("Butter");

            CrossSecondStep(7);
        }
        if (CounterScript.counter == 8) //Vanilla
        {
            ActivateDragAndDrop("Vanilla");
        }
        if (CounterScript.counter == 9) //BOWL1 + CHANGE TO BOWL 2 + List3
        {
            ActivateDragAndDrop("Bowl1");

            ChangeSecondList(9); //change list again
        }
        if (CounterScript.counter == 10) //Spoon
        {
            ActivateDragAndDrop("Spoon");

            CrossFirstStep(10);
        }
        if (CounterScript.counter == 11) //Bowl2 + CHANGE TO W MAKER
        {
            ActivateDragAndDrop("Bowl2");

            CrossSecondStep(11);
        }
        if (CounterScript.counter == 12) //CHANGE W MAKER SPRITES
        {
            PutComposition();

            //after 4 seconds make it close
            Invoke("NextStep", 4f);

            CrossThirdStep(12);
        }
        if (CounterScript.counter == 13)
        {
            CloseWMaker();

            Invoke("ActivateDonePanel", 2f);

            FindObjectOfType<AudioManager>().PlayAudio("WellDone");
        }
    }

    void ActivateDragAndDrop(string s)
    {
        if (gameObject.name == s)
            DnDScript.enabled = true;
    }

    void ChangeSpriteDeactivate(GameObject obj1)
    {
        if (obj1 != null)
        {
            obj1.SetActive(false); //Make the object invisible
        }
    }

    void ChangeSpriteActivate(GameObject obj)
    {
        if (obj != null)
        {
            obj.SetActive(true); //Make the object visible
        }
    }

    void CloseWMaker() //Next time use Coroutine 
    {
        ChangeSpriteDeactivate(WMakerFull);
        ChangeSpriteActivate(WMakerClosed);
    }

    void PutComposition() 
    {
        ChangeSpriteDeactivate(WMakerEmpty);
        ChangeSpriteActivate(WMakerFull);
    }

    void CrossFirstStep(int nr)
    {
        if(XCrossScript != null)
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

    void NextStep()
    {
        CounterScript.counter = 13;
    }

    void ActivateDonePanel()
    {
        if (DonePanel != null)
        {
            DonePanel.SetActive(true);
        }
    }
}
