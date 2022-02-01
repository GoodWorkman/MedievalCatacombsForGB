using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MeeleEnemy : MonoBehaviour
{
    private Transform _player;
    private NavMeshAgent _agent;

    private bool _isAngry = false;
    
    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _player = FindObjectOfType<PlayerMove1>().transform;
    }

    private void Update()
    {
        if (!_isAngry) return;
        
        _agent.SetDestination(_player.position);
    }

    public void Burn()
    {
        _isAngry = true;
    }

    public void Relax()
    {
        _isAngry = false;
        //_agent.SetDestination(transform.position);
    }

    


}
