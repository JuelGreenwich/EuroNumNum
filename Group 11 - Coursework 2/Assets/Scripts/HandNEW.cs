using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandNEW : MonoBehaviour
{
    [SerializeField] private Camera theCamera;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(theCamera.ScreenToWorldPoint(Input.mousePosition));
        //Debug.Log(Input.mousePosition);
        Vector3 mouseWorldPosition = theCamera.ScreenToWorldPoint(Input.mousePosition);
        print(mouseWorldPosition);
        mouseWorldPosition.z = 7;
        transform.position = mouseWorldPosition;
        //var inputMousePos = Input.mousePosition;
        //inputMousePos.z = 1.1f;
        //var mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(inputMousePos);
        //transform.position = mousePosition;
    }
}
