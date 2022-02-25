using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddIntoBowl : MonoBehaviour
{
    [SerializeField] DragAndDropNEW DaDScript;
    bool canBeAdded;
    GameObject objectColl;

    void Start()
    {
        
    }

    void Update()
    {
        if(canBeAdded && DaDScript.isPicked == false)
        {
            print("Added");
            //note as added
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        print("collision");
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
}
