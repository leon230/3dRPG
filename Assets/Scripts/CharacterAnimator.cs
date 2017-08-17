﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterAnimator : MonoBehaviour {

    const float animationSmoothTime = 0.1f;
    NavMeshAgent agent;
    Animator animatior;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        animatior = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //Speed divided by max speed
        float speedPercent = agent.velocity.magnitude / agent.speed;
        animatior.SetFloat("speedPercent", speedPercent, animationSmoothTime, Time.deltaTime);

	}
}
