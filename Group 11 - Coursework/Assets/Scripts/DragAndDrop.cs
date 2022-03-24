using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public bool isPicked;

    private void OnMouseDown()
    {
        isPicked = true;
    }

    public void OnMouseUp()
    {
        isPicked = false;
    }

    void Update()
    {
        if (isPicked)
        {
        var inputMousePos = Input.mousePosition;
        inputMousePos.z = 7;
        var mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(inputMousePos);
            transform.position = mousePosition;
        }
    }
}
