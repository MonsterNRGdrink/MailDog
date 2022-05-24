using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DogMovement : MonoBehaviour
{


    NavMeshAgent agent;

    public float rotateSpeedMovement = 0.1f;
    float rotateVelocity;

    void Start ()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
    }


    void Update () 
    {
        if(Input.GetMouseButtonDown(1)) 
        {
            RaycastHit hit;

            
            //Checking if the raycast shot hits something that uses the navmesh system.
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity)) 
            {

                //Have the player move to the Raycast point.
                agent.SetDestination(hit.point);

                //Rotation
                Quaternion rotationToLookAt = Quaternion.LookRotation(hit.point - transform.position);
                float rotationY = Mathf.SmoothDampAngle(transform.eulerAngles.y,
                    rotationToLookAt.eulerAngles.y,
                    ref rotateVelocity,
                    rotateSpeedMovement * (Time.deltaTime * 5));

                    transform.eulerAngles = new Vector3(0, rotationY, 0);
            }
        }
    }
}