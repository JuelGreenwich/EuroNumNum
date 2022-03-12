using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemOnBoard : MonoBehaviour
{
    public bool cucumberOnBoard;
    public bool onionOnBoard;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.name == "CucumberFull")
        {
            print("cuc coll with board");
            cucumberOnBoard = true;
        }
        if (other.gameObject.name == "OnionFull")
        {
            print("on coll with board");
            onionOnBoard = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //print("exit board");
        //onionOnBoard = false;
        //cucumberOnBoard = false;
    }
}
