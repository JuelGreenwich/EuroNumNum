using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavMeshPlayerController : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [SerializeField] UnityEngine.AI.NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) //left mouse click
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            //print("ray is " + ray); //Origin: *camera coordinates* (Vector3), Dir: *direction to the mouse* (Vector3)
            //Example: ray is Origin: (-30.3, 19.7, -0.2), Dir: (0.8, -0.6, 0.0)
            RaycastHit hit; 

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
                print("hit is " + hit); //UnityEngine.RaycastHit
                print(agent.SetDestination(hit.point)); //prints True
                print(hit.point); //prints the coordiates of the mouse (Vector3), for example (-2.5, 0.0, -1.5)
            }
        }
    }
}
