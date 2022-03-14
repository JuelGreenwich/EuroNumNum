using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddIntoBowl : MonoBehaviour
{
    [SerializeField] DragAndDropNEW DaDScript;
    bool canBeAdded;
    GameObject objectColl;
    public bool addedInBowl = false; //for the SpriteChange script, not useful in this script 
    [SerializeField] CounterOrderIngredients CounterScript;
    
    //Egg part
    public bool egg1added;
    public bool egg2added;


    void Update()
    {
        if(canBeAdded && DaDScript.isPicked == false) //when the click is released
        {
            print("Added");
            addedInBowl = true;

            if(gameObject.tag == "Egg")
            {
                Invoke("ItemDisappear", 2f);
            }
            else
            {
                CounterScript.counter++;
                ItemDisappear();
            }

        }
        else
        {
            //addedInBowl = false; //resets it for other eggs - RESET DOESN'T WORK
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        objectColl = collider.gameObject;
        if (objectColl.tag == "Bowl")
        {
            print("over the bowl");
            canBeAdded = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        canBeAdded = false;
    }

    public void ItemDisappear()
    {
        Destroy(gameObject);
    }
}
