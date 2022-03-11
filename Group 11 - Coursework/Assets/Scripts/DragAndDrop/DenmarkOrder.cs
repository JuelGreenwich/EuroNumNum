using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DenmarkOrder : MonoBehaviour
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
        if(CounterScript.counter == 1)
        {
            ActivateDragAndDrop("Bread");
        }
        if (CounterScript.counter == 2)
        {
            ActivateDragAndDrop("Mayo");
        }
        if (CounterScript.counter == 3)
        {
            ActivateDragAndDrop("Salmon");
        }

    }

    void ActivateDragAndDrop( string s)
    {
        if(gameObject.name == s)
        DnDScript.enabled = true;
    }
}
