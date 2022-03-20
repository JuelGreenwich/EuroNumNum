using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListShop : MonoBehaviour
{
    [SerializeField] GameObject[] Lists;
    CounterOrderIngredients CounterScript;
    // Start is called before the first frame update
    void Start()
    {
        CounterScript = GetComponent<CounterOrderIngredients>();
        Lists[0].SetActive(false);
        Lists[1].SetActive(false);
        Lists[2].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (CounterScript.counter == 6)
        {
            Lists[0].SetActive(true);
        }
        if (CounterScript.counter == 13)
        {
            Lists[1].SetActive(true);
        }
        if (CounterScript.counter == 20)
        {
            Lists[2].SetActive(true);
        }
    }
}
