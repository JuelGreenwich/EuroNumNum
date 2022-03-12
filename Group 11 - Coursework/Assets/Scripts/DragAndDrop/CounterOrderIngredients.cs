using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterOrderIngredients : MonoBehaviour
{
    public int counter = 1;
    [SerializeField] GameObject[] Plates;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Plates[counter].SetActive(true);
    }

}
