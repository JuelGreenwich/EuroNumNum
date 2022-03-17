using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharMovment : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Move The Agent
                agent.SetDestination(hit.point);
            }
        }
        animator.SetFloat("Move", agent.velocity.magnitude);
    }
}
