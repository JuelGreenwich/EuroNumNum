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
        if (CounterScript.counter == 6) //Eggs
        {
            ActivateDragAndDrop("Egg1");
            ActivateDragAndDrop("Egg2");
        }
        if (CounterScript.counter == 7) //SaucePan
        {
            ActivateDragAndDrop("SaucePan");
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
        }
        if (CounterScript.counter == 11) //Onion2
        {
            ActivateDragAndDrop("Onion2");
            ActivateDragAndDrop("OnionCut2");
        }
        if (CounterScript.counter == 12) //Sauce
        {
            ActivateDragAndDrop("Sauce");
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

        }
        if (CounterScript.counter == 14) //Pasley
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
