using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavMeshPlayerController : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [SerializeField] UnityEngine.AI.NavMeshAgent agent;
    [SerializeField] Animator mAnimator;

    bool Forward = false;

    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) //left mouse click
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            Debug.Log("true");
            Forward = true;
            RaycastHit hit;

            mAnimator.SetBool("Foward", Forward);

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
        
    }
}
