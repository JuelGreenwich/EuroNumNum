using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggStop : MonoBehaviour
{
    [SerializeField] AddIntoBowl AddBowl;
    private void OnTriggerEnter(Collider other)
    {
        if (AddBowl.addedInBowl == true)
        {
            if (other.tag == "Egg");
            {
                //print("eggTrigger");
                Destroy(other.gameObject);
            }
        }

    }
}
