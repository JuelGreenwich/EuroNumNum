using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlovakiaScoop : MonoBehaviour
{
    [SerializeField] GameObject MeatBalls;
    DragAndDropNEW DnDScript;
    [SerializeField] SlovakiaItemOnBoard OnBoardScript;

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
        if (other.gameObject.name == "Mix")
        {
            if (DnDScript.isPicked == true && OnBoardScript.mixOnBoard == true)
            {
                other.gameObject.SetActive(false);
                MeatBalls.SetActive(true);
            }
        }
    }
}
