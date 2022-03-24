using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeSpain : MonoBehaviour
{
    [SerializeField] GameObject OnionCut;
    [SerializeField] GameObject PepperCut;
    [SerializeField] GameObject GarlicCut;
    [SerializeField] GameObject SausageCut;
    [SerializeField] GameObject TomatoCut;
    [SerializeField] GameObject PasleyoCut;
    DragAndDropNEW DnDScript;
    [SerializeField] SpainItemOnBoard OnBoardScript;

    void Start()
    {
        DnDScript = gameObject.GetComponent<DragAndDropNEW>();
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Onion")
        {
            if (DnDScript.isPicked == true && OnBoardScript.onionOnBoard == true) //check if the knife is in hand and if the object is on the board
            {
                other.gameObject.SetActive(false);
                OnionCut.SetActive(true);

                FindObjectOfType<AudioManager>().PlayAudio("Knife");
            }
        }

        if (other.gameObject.name == "Pepper")
        {
            if (DnDScript.isPicked == true && OnBoardScript.pepperOnBoard == true)
            {
                other.gameObject.SetActive(false);
                PepperCut.SetActive(true);

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

        if (other.gameObject.name == "Sausage")
        {
            if (DnDScript.isPicked == true && OnBoardScript.sausageOnBoard == true)
            {
                other.gameObject.SetActive(false);
                SausageCut.SetActive(true);

                FindObjectOfType<AudioManager>().PlayAudio("Knife");
            }
        }

        if (other.gameObject.name == "Tomato")
        {
            if (DnDScript.isPicked == true && OnBoardScript.tomatoOnBoard == true)
            {
                other.gameObject.SetActive(false);
                TomatoCut.SetActive(true);

                FindObjectOfType<AudioManager>().PlayAudio("Knife");
            }
        }

        if (other.gameObject.name == "Pasley")
        {
            if (DnDScript.isPicked == true && OnBoardScript.pasleyOnBoard == true)
            {
                other.gameObject.SetActive(false);
                PasleyoCut.SetActive(true);

                FindObjectOfType<AudioManager>().PlayAudio("Knife");
            }
        }
    }
}
