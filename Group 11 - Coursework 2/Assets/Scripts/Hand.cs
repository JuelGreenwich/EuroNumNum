using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var inputMousePos = Input.mousePosition;
        inputMousePos.z = 1.1f;
        var mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(inputMousePos);
        //print(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        transform.position = mousePosition;
    }
}
