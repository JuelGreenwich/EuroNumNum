using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BelgiumChangeBowl : MonoBehaviour
{
    CounterOrderIngredients CounterScript;
    [SerializeField] GameObject Bowl1;
    [SerializeField] GameObject Bowl2;
    [SerializeField] GameObject WMaker;

    // Start is called before the first frame update
    void Start()
    {
        CounterScript = GetComponent<CounterOrderIngredients>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CounterScript.counter == 5)
        {
            Bowl2.tag = "Untagged";
            Bowl1.tag = "Bowl";
        }
        if (CounterScript.counter == 9)
        {
            Bowl1.tag = "Untagged";
            Bowl2.tag = "Bowl";
        }
        if (CounterScript.counter == 11)
        {
            Bowl2.tag = "Untagged";
            WMaker.tag = "Bowl";
        }
    }
}
