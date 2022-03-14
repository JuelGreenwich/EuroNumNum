using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XCross : MonoBehaviour
{
    CounterOrderIngredients CounterScript;
    [SerializeField] Image X1;
    [SerializeField] Image X2;
    [SerializeField] Image X3;

    public int stepX1isCrossed;
    public int stepX2isCrossed;
    public int stepX3isCrossed;
    public int changeList1;
    public int changeList2;

    // Start is called before the first frame update
    void Start()
    {
        CounterScript = GetComponent<CounterOrderIngredients>();

        X1.enabled = false;
        X2.enabled = false;
        X3.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (CounterScript.counter == stepX1isCrossed)
        {
            //print("got to step");
            X1.enabled = true;
        }
        if (CounterScript.counter == stepX2isCrossed)
        {
            X2.enabled = true;
        }
        if (CounterScript.counter == stepX3isCrossed)
        {
            X3.enabled = true;
        }
        if (CounterScript.counter == changeList1 || CounterScript.counter == changeList2)
        {
            //Invoke("ResetX", 3f);
            ResetX();
        }
    }

    void ResetX()
    {
        X1.enabled = false;
        X2.enabled = false;
        X3.enabled = false;

        stepX1isCrossed = 0;
        stepX2isCrossed = 0;
        stepX3isCrossed = 0;
    }
}
