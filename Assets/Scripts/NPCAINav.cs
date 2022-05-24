using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NPCAINav : MonoBehaviour
{
    public GameObject theDestination;
    NavMeshAgent agent;

   void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
            agent.SetDestination(theDestination.transform.position);
    }
}
