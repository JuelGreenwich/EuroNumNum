using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BelgiumOrder : MonoBehaviour
{
    DragAndDropNEW DnDScript;
    int counter = 1;
    [SerializeField] CounterOrderIngredients CounterScript;

    [SerializeField] GameObject WMakerEmpty;
    [SerializeField] GameObject WMakerFull;
    [SerializeField] GameObject WMakerClosed;


    // Start is called before the first frame update
    void Start()
    {
        DnDScript = gameObject.GetComponent<DragAndDropNEW>();
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
        }
        if (CounterScript.counter == 3) //Sugar
        {
            ActivateDragAndDrop("Sugar");
        }
        if (CounterScript.counter == 4) //Salt
        {
            ActivateDragAndDrop("Salt");
        }
        if (CounterScript.counter == 5) //Milk + CHANGE TO BOWL 1
        {
            ActivateDragAndDrop("Milk");
        }
        if (CounterScript.counter == 6) //Eggs
        {
            ActivateDragAndDrop("Egg1");
            ActivateDragAndDrop("Egg2");
        }
        if (CounterScript.counter == 7) //Butter
        {
            ActivateDragAndDrop("Butter");
        }
        if (CounterScript.counter == 8) //Vanilla
        {
            ActivateDragAndDrop("Vanilla");
        }
        if (CounterScript.counter == 9) //BOWL1 + CHANGE TO BOWL 2 + List3
        {
            ActivateDragAndDrop("Bowl1");
        }
        if (CounterScript.counter == 10) //Spoon
        {
            ActivateDragAndDrop("Spoon");
        }
        if (CounterScript.counter == 11) //Bowl2 + CHANGE TO W MAKER
        {
            ActivateDragAndDrop("Bowl2");
        }
        if (CounterScript.counter == 12) //CHANGE W MAKER SPRITES
        {
            ChangeSpriteDeactivate(WMakerEmpty); //delete the empty one
            ChangeSpriteActivate(WMakerFull); //make the full one appear

            CounterScript.counter = 13;
        }
        if (CounterScript.counter == 13)
        {
            //after 3 seconds make it close
            Invoke("CloseWMaker", 4f);

            //Invoke("ChangeSpriteDeactivate(WMakerFull)", 3f); - INVOKE doesn't work for functions with parameters  
        }
    }

    void ActivateDragAndDrop(string s)
    {
        if (gameObject.name == s)
            DnDScript.enabled = true;
    }

    void ChangeSpriteDeactivate(GameObject obj)
    {
        if (obj != null)
        {
            obj.SetActive(false); //Make the object invisible
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
}
