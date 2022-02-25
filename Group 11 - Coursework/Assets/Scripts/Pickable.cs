using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    [SerializeField] Collider itemCollider;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Hand")
        {
            //print("collided with hand");
        //Collider itemCollider = collision.collider;
        itemCollider.isTrigger = true; //make it Trigger so that OnMouseDown() function works
        //print("is Trigger true");
        }
    }

    void OnCollisionExit(Collision collision)
    {
        itemCollider.isTrigger = false;
        if (collision.gameObject.tag == "Hand")
        {

            //print("is Trigger false");
        }
    }

    void Update()
    {
        
    }
}
