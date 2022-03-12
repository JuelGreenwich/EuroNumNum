using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlovakiaOrder : MonoBehaviour
{
    DragAndDropNEW DnDScript;
    int counter = 1;
    [SerializeField] CounterOrderIngredients CounterScript;

    // Start is called before the first frame update
    void Start()
    {
        DnDScript = gameObject.GetComponent<DragAndDropNEW>();
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
            ActivateDragAndDrop("Water1"); //Water
        }
        if (CounterScript.counter == 3) //Meat + CHANGE POT 
        {
            ActivateDragAndDrop("Meat"); 
            ActivateDragAndDrop("SaucePan"); 
        }
        if (CounterScript.counter == 4) //Onion
        {
            ActivateDragAndDrop("Knife");
            ActivateDragAndDrop("Onion1");
            ActivateDragAndDrop("OnionCut1");
        }
        if (CounterScript.counter == 5) //Garlic
        {
            ActivateDragAndDrop("Garlic");
            ActivateDragAndDrop("GarlicCut");
        }
        if (CounterScript.counter == 6) //Egg1
        {
            ActivateDragAndDrop("Egg1");
        }
        if (CounterScript.counter == 7) //Egg2
        {
            ActivateDragAndDrop("Egg2");
        }
        if (CounterScript.counter == 8) //SaucePan
        {
            ActivateDragAndDrop("SaucePan");
        }
        if (CounterScript.counter == 9) //Salt
        {
            ActivateDragAndDrop("Salt");
        }
        if (CounterScript.counter == 10) //Pepper 
        {
            ActivateDragAndDrop("Pepper");
        }
        if (CounterScript.counter == 11) //Oil + CHANGE POT
        {
            ActivateDragAndDrop("Oil");
            ActivateDragAndDrop("Bowl");
        }
        if (CounterScript.counter == 12) //Onion2
        {
            ActivateDragAndDrop("Onion2");
            ActivateDragAndDrop("OnionCut2");
        }
        if (CounterScript.counter == 13) //Sauce
        {
            ActivateDragAndDrop("Sauce");
        }
        if (CounterScript.counter == 14) //MixBowl to Board
        {
            ActivateDragAndDrop("MixBowl");
            //activate some hand
        }
        if (CounterScript.counter == 15) //Pasley
        {
            ActivateDragAndDrop("Water2");
        }
    }

    void ActivateDragAndDrop(string s)
    {
        if (gameObject.name == s)
            DnDScript.enabled = true;
    }
}
