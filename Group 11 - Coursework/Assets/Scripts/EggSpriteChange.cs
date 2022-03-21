using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSpriteChange : MonoBehaviour
{
    [SerializeField] Sprite EggMissingSprite;
    [SerializeField] Sprite YolkSprite;
    SpriteRenderer spriteRenderer;
    [SerializeField] DragAndDropNEW DnD; //you drag the object
    [SerializeField] AddIntoBowl AddBowl;
    Rigidbody rigidBody;
    Collider coll;

    [SerializeField] CounterOrderIngredients CounterScript;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        coll = GetComponent<Collider>();
    }

    void Update()
    {
        if (gameObject.tag == "Egg")
        {
            if (AddBowl.addedInBowl == true)
            {
                spriteRenderer.sprite = YolkSprite; //change the sprite to the yolk
                coll.isTrigger = true; //so that you can use OnTriggerEnter AND so that it doesn't get stoped by the bowl collider
                rigidBody.isKinematic = false; //false so that you can apply force 
                rigidBody.AddForce(transform.up * -0.5f); //moves down
                                                          //ChangeSprite();

                CounterScript.counter = 7;

                FindObjectOfType<AudioManager>().PlayAudio("EggCracked");
            }
        }
        if (gameObject.tag == "EggRack")
        {
            //if (DnD.isPicked == true)
            //{
            //    spriteRenderer.sprite = EggMissingSprite;
            //    spriteRenderer.sortingOrder = 1;
            //    //ChangeSprite();
            //}
        }

    }

    public void ChangeSprite()
    {
        //spriteRenderer.sprite = newSprite;
        //spriteRenderer.sortingOrder = 1;
    }
}
