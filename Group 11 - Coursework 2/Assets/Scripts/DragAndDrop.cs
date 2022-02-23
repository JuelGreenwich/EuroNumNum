﻿using System.Collections;
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
        print(isPicked);
        if (isPicked)
        {
        var inputMousePos = Input.mousePosition;
        inputMousePos.z = 7;
        var mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(inputMousePos);
        //print(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            transform.position = mousePosition;
        }
    }
}
