using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlovakiaChangePot : MonoBehaviour
{
    CounterOrderIngredients CounterScript;
    [SerializeField] GameObject SaucePan;
    [SerializeField] GameObject Bowl;
    [SerializeField] GameObject Pot;

    // Start is called before the first frame update
    void Start()
    {
        CounterScript = GetComponent<CounterOrderIngredients>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CounterScript.counter == 3)
        {
            SaucePan.tag = "Untagged";
            Bowl.tag = "Bowl";
        }
        if (CounterScript.counter == 11)
        {
            Bowl.tag = "Untagged";
            Pot.tag = "Bowl";
        }
    }
}
