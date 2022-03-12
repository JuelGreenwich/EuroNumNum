using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListChange : MonoBehaviour
{
    [SerializeField] GameObject[] Lists;
    CounterOrderIngredients CounterScript;
    [SerializeField] GameObject[] recipes;
    [SerializeField] int stepWhenFirstListChanges;
    [SerializeField] int stepWhenSecondListChanges;
    // Start is called before the first frame update
    void Start()
    {
        CounterScript = GetComponent<CounterOrderIngredients>();
        Lists[0].SetActive(false);
        Lists[1].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (CounterScript.counter == stepWhenFirstListChanges) 
        {
            Lists[0].SetActive(true);
            Destroy(recipes[0]);
        }
        if (CounterScript.counter == stepWhenSecondListChanges) 
        {
            Lists[1].SetActive(true);
            Destroy(recipes[1]);
        }
    }
}
