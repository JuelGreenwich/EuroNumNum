using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeDenmark : MonoBehaviour
{
    [SerializeField] GameObject newCucumber;
    [SerializeField] GameObject newOnion;
    DragAndDropNEW DnDScript;
    [SerializeField] ItemOnBoard OnBoardScript;

    void Start()
    {
        DnDScript = gameObject.GetComponent<DragAndDropNEW>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "CucumberFull")
        {
            print("collided with cucumber");
            if(DnDScript.isPicked == true && OnBoardScript.cucumberOnBoard == true)
            {
            other.gameObject.SetActive(false);
            newCucumber.SetActive(true);
            }
        }
        if(other.gameObject.name == "OnionFull")
        {
            print("collided with onion");
            if (DnDScript.isPicked == true && OnBoardScript.onionOnBoard == true)
            {
            other.gameObject.SetActive(false);
            newOnion.SetActive(true);
            }
        }
    }
}
