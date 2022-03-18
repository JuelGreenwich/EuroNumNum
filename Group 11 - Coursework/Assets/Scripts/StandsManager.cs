using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandsManager : MonoBehaviour
{
    public bool canEnterBelgium;
    [SerializeField] CounterOrderIngredients CounterScript;
    // Start is called before the first frame update
    void Start()
    {
        //CounterScript = GameObject.FindGameObjectWithTag("Counter").GetComponent<CounterOrderIngredients>();
        //CounterScript = GetComponent<CounterOrderIngredients>();
        canEnterBelgium = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Counter") != null)
        {
            CounterScript = GameObject.FindGameObjectWithTag("Counter").GetComponent<CounterOrderIngredients>();
        }
        if (CounterScript != null)
        {
            if(gameObject.name == "BelgiumDD" && CounterScript.counter == 2) //and if counter
            {
                //finished
                canEnterBelgium = false;
            }
        }

    }
}
