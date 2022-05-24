using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogAnimator : MonoBehaviour
{


    public UnityEngine.AI.NavMeshAgent agent;
    public Animator anim;

    float motionSmoothTime = .1f; 

    void Start()
    {
        agent = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = agent.velocity.magnitude / agent.speed;
        anim.SetFloat("Speed", speed, motionSmoothTime, Time.deltaTime);
    }
}
