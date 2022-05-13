using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class CharacterMovement : MonoBehaviour {

    private NavMeshAgent agent;
    [SerializeField] private Transform targetObject;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }

    /*
  void Update() {
    if (Input.GetMouseButtonDown(0)) {
      RaycastHit hitInfo;

      if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, Mathf.Infinity))
      {
        agent.SetDestination(hitInfo.point);
        agent.stoppingDistance = 0;
      }
    }
  }
    */

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, Mathf.Infinity))
            {
                targetObject.position = hitInfo.point;
                agent.SetDestination(targetObject.position);
            }
        }


        /*NavMeshHit targetLocation;
        NavMesh.FindClosestEdge(targetObject.position, out targetLocation, NavMesh.AllAreas);
        agent.SetDestination(targetLocation.position);
        */
    }
}