using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggStop : MonoBehaviour
{
    [SerializeField] AddIntoBowl[] AddBowl;
    private void OnTriggerEnter(Collider other)
    {
        if (AddBowl[0].addedInBowl == true)
        {
            if (other.tag == "Egg")
            {
                AddBowl[0].addedInBowl = false;
                Destroy(other.gameObject);
            }
        }
        if (AddBowl[1].addedInBowl == true)
        {
            if (other.tag == "Egg")
            {
                AddBowl[1].addedInBowl = false;
                Destroy(other.gameObject);
            }
        }

    }
}
