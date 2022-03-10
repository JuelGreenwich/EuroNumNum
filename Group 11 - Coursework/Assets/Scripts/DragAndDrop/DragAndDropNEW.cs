using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropNEW : MonoBehaviour
{
    public bool isPicked;

    private void OnMouseDown() //This function is called on Colliders marked as Trigger that also have a RigidBody
    {
        isPicked = true;
    }

    public void OnMouseUp()
    {
        isPicked = false;
    }

    void Update()
    {
        //print(isPicked);
        if (isPicked)
        {
            var inputMousePos = Input.mousePosition;
            inputMousePos.z = 1.7f;
            var mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(inputMousePos);
            //print(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            transform.position = mousePosition;
        }
    }
}
