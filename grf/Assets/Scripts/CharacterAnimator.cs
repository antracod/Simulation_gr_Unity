using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterAnimator : MonoBehaviour {

    const float locomationAnimationSmoothTime = .1f;

    NavMeshAgent agent;
    public Animator animator;

	void Start () {
        agent = GetComponent<NavMeshAgent>();
        
	}
	
	void Update () {
        
        float speedPercent = agent.velocity.magnitude / agent.speed;

        animator.SetFloat("speedPercent", speedPercent, locomationAnimationSmoothTime, Time.deltaTime);
	}
}
