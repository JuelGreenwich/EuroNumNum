using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpainChangePot : MonoBehaviour
{
    CounterOrderIngredients CounterScript;
    [SerializeField] GameObject SaucePan;
    [SerializeField] GameObject Pan;

    // Start is called before the first frame update
    void Start()
    {
        CounterScript = GetComponent<CounterOrderIngredients>();
    }

    // Update is called once per frame
    void Update()
    {
        if(CounterScript.counter == 3)
        {
            SaucePan.tag = "Untagged";
            Pan.tag = "Bowl";
        }
    }
}
