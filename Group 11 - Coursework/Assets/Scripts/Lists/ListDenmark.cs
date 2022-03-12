using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListDenmark : MonoBehaviour
{
    [SerializeField] GameObject SecondList;
    [SerializeField] CounterOrderIngredients CounterScript;
    [SerializeField] GameObject recipe;
    // Start is called before the first frame update
    void Start()
    {
        SecondList.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(CounterScript.counter == 5)
        {
        SecondList.SetActive(true);
        Destroy(recipe);
        }
    }
}
