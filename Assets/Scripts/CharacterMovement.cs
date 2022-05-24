using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]
public class CharacterMovement : MonoBehaviour {

    private Animator animator;
    private NavMeshAgent agent;
    [SerializeField] private Transform targetObject;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
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
    }
}