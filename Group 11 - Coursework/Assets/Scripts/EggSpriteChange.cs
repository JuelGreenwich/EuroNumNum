using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSpriteChange : MonoBehaviour
{
    [SerializeField] Sprite[] EggMissingSprite; //array of sprites: Egg rack with missing eggs
    [SerializeField] Sprite YolkSprite;
    SpriteRenderer spriteRenderer;
    [SerializeField] DragAndDropNEW[] DnD; //Array for all eggs that checks if they are picked
    [SerializeField] AddIntoBowl AddBowl;
    Rigidbody rigidBody;
    Collider coll;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        coll = GetComponent<Collider>();
        //AddBowl = GetComponent<AddIntoBowl>();
    }

    void Update()
    {
        if(gameObject.tag == "Egg")
        {
            if (AddBowl.addedInBowl == true)
            {
                spriteRenderer.sprite = YolkSprite; //change the sprite to the yolk
                coll.isTrigger = true; //so that you can use OnTriggerEnter AND so that it doesn't get stoped by the bowl collider
                rigidBody.isKinematic = false; //false so that you can apply force 
                rigidBody.AddForce(transform.up * -0.5f); //moves down
            }
        }
        if(gameObject.tag == "EggRack") //if you pick an egg in your hand, the rack changes sprites  
        {
            if (DnD[0].isPicked == true) //The first egg
            {
                ChangeSprite(0); //changes to the sprite where an egg is missing
            }
            if (DnD[1].isPicked == true) //The second egg
            {
                ChangeSprite(1); //changes to the sprite where two eggs are missing
            }
        }

    }

    public void ChangeSprite(int n)
    {
        spriteRenderer.sprite = EggMissingSprite[n]; //
        spriteRenderer.sortingOrder = n+1;
        //spriteRenderer.sprite = newSprite;
        //spriteRenderer.sortingOrder = 1;
    }
}
