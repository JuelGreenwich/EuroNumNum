using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListSlovakia : MonoBehaviour
{
    [SerializeField] GameObject[] Lists;
    CounterOrderIngredients CounterScript;
    [SerializeField] GameObject[] recipes;
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
        if (CounterScript.counter == 6) //after garlic
        {
            Lists[0].SetActive(true);
            Destroy(recipes[0]);
        }
        if (CounterScript.counter == 13) //after second onion
        {
            Lists[1].SetActive(true);
            Destroy(recipes[1]);
        }
    }
}
