using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DenmarkPlates : MonoBehaviour
{
    [SerializeField] GameObject[] Plates;
    CounterOrderIngredients CounterScript;

    void Start()
    {
        CounterScript = GetComponent<CounterOrderIngredients>();
    }

    // Update is called once per frame
    void Update()
    {
        Plates[CounterScript.counter].SetActive(true);
    }
}
