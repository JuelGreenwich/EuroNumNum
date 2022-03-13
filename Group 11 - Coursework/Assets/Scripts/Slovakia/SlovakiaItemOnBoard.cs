using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlovakiaItemOnBoard : MonoBehaviour
{
    public bool onionOnBoard1;
    public bool onionOnBoard2;
    public bool garlicOnBoard;
    public bool mixOnBoard;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Onion1")
        {
            print("on board");
            onionOnBoard1 = true;
        }
        if (other.gameObject.name == "Onion2")
        {
            onionOnBoard2 = true;
        }
        if (other.gameObject.name == "Garlic")
        {
            garlicOnBoard = true;
        }
        if (other.gameObject.name == "Mix")
        {
            mixOnBoard = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //print("exit board");
        //onionOnBoard = false;
    }
}
