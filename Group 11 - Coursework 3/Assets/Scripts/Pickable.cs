using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        Collider itemCollider = collision.collider;
        itemCollider.isTrigger = true;
        print("is Trigger true");
    }

    private void OnCollisionExit(Collision collision)
    {
        Collider itemCollider = collision.collider;
        itemCollider.isTrigger = false;
        print("is Trigger false");
    }

    void Update()
    {
        
    }
}
