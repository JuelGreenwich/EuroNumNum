using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandsManager : MonoBehaviour
{


    //Counter script
    [SerializeField] CounterOrderIngredients CounterScript;

    //Check if you can enter panels
    public bool canEnterBelgium;
    public bool canEnterSlovakia;
    public bool canEnterDenmark;
    public bool canEnterSpain;
    public bool canEnterShop;

    void Start()
    {
        canEnterBelgium = true;
        canEnterSlovakia = true;
        canEnterDenmark = true;
        canEnterSpain = true;
        canEnterShop = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Get reference to the Counter
        if (GameObject.FindGameObjectWithTag("Counter") != null)
        {
            CounterScript = GameObject.FindGameObjectWithTag("Counter").GetComponent<CounterOrderIngredients>();
        }

        if (CounterScript != null)
        {
            print(CounterScript.counter);

            //Belgium
            if (CounterScript.gameObject.name == "CounterBelgium" && CounterScript.counter == 13) 
            {
                canEnterBelgium = false;
            }

            //Slovakia
            if (CounterScript.gameObject.name == "CounterSlovakia" && CounterScript.counter == 15) 
            {
                canEnterSlovakia = false;
            }

            //Denmark
            if (CounterScript.gameObject.name == "CounterDenmark" && CounterScript.counter == 8)
            {
                canEnterDenmark = false;
            }

            //Spain
            if (CounterScript.gameObject.name == "CounterSpain" && CounterScript.counter == 16)
            {
                canEnterSpain = false;
            }

            //Shop
            if (CounterScript.gameObject.name == "CounterShop" && CounterScript.counter == 30)
            {
                canEnterShop = false;
            }
        }
    }
}
