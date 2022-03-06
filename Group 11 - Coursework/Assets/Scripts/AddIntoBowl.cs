using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddIntoBowl : MonoBehaviour
{
    [SerializeField] DragAndDropNEW DaDScript;
    bool canBeAdded;
    GameObject objectColl;
    public bool addedInBowl = false; //for the SpriteChange script, not useful in this script 

    void Update()
    {
        if(canBeAdded && DaDScript.isPicked == false)
        {
            print("Added");
            addedInBowl = true;

            //Destroy(gameObject); - the old method
            if(gameObject.tag == "Egg")
            {
                Invoke("ItemDisappear", 2f); //Delays the Destroy function so that you can see the yolk falling
            }
            else
            {
                ItemDisappear();
            }

        }
        else
        {
            addedInBowl = false; //resets it for other eggs
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        //print("collision");
        objectColl = collider.gameObject;
        if (objectColl.tag == "Bowl")
        {
            print("over the bowl");
            canBeAdded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canBeAdded = false;
    }

    public void ItemDisappear()
    {
        Destroy(gameObject);
    }
}
