using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggCounter : MonoBehaviour
{
    [SerializeField] EggSpriteChange EggScript;
    CounterOrderIngredients CounterScript;

    void Start()
    {
        CounterScript = GetComponent<CounterOrderIngredients>();
    }

    // Update is called once per frame
    void Update()
    {
        if(CounterScript.counter == 2)
        {
        //EggScript.enabled = true;
        }
    }
}
