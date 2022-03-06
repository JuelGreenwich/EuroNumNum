using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    [SerializeField] Collider itemCollider;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Hand")
        {
        //Collider itemCollider = collision.collider;
        itemCollider.isTrigger = true; //make it Trigger so that OnMouseDown() function works
        }
    }

    void OnCollisionExit(Collision collision)
    {
        itemCollider.isTrigger = false;
    }

    void Update()
    {
        
    }
}
