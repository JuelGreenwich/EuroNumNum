using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpainItemOnBoard : MonoBehaviour
{
    public bool pepperOnBoard;
    public bool onionOnBoard;
    public bool garlicOnBoard;
    public bool sausageOnBoard;
    public bool tomatoOnBoard;
    public bool pasleyOnBoard;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Onion")
        {
            onionOnBoard = true;
        }
        if (other.gameObject.name == "Pepper")
        {
            pepperOnBoard = true;
        }
        if (other.gameObject.name == "Garlic")
        {
            garlicOnBoard = true;
        }
        if (other.gameObject.name == "Pepper")
        {
            pepperOnBoard = true;
        }
        if (other.gameObject.name == "Sausage")
        {
            sausageOnBoard = true;
        }
        if (other.gameObject.name == "Tomato")
        {
            tomatoOnBoard = true;
        }
        if (other.gameObject.name == "Pasley")
        {
            pasleyOnBoard = true;
        }
        

    }

    private void OnTriggerExit(Collider other)
    {
        //print("exit board");
        //onionOnBoard = false;
        //cucumberOnBoard = false;
    }
}
