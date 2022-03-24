using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeSlovakia : MonoBehaviour
{
    [SerializeField] GameObject OnionCut1;
    [SerializeField] GameObject OnionCut2;
    [SerializeField] GameObject GarlicCut;
    [SerializeField] GameObject MeatBalls;
    DragAndDropNEW DnDScript;
    [SerializeField] SlovakiaItemOnBoard OnBoardScript;

    void Start()
    {
        DnDScript = gameObject.GetComponent<DragAndDropNEW>();
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Onion1")
        {
            if (DnDScript.isPicked == true && OnBoardScript.onionOnBoard1 == true) //check if the knife is in hand and if the object is on the board
            {
                other.gameObject.SetActive(false);
                OnionCut1.SetActive(true);

                FindObjectOfType<AudioManager>().PlayAudio("Knife");
            }
        }
        if (other.gameObject.name == "Onion2")
        {
            if (DnDScript.isPicked == true && OnBoardScript.onionOnBoard2 == true) //check if the knife is in hand and if the object is on the board
            {
                other.gameObject.SetActive(false);
                OnionCut2.SetActive(true);

                FindObjectOfType<AudioManager>().PlayAudio("Knife");
            }
        }
        if (other.gameObject.name == "Garlic")
        {
            if (DnDScript.isPicked == true && OnBoardScript.garlicOnBoard == true)
            {
                other.gameObject.SetActive(false);
                GarlicCut.SetActive(true);

                FindObjectOfType<AudioManager>().PlayAudio("Knife");
            }
        }
    }
}
