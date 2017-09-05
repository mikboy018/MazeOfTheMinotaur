using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BaddieWalkScript : MonoBehaviour {

    public Transform destination;

    private NavMeshAgent agent;

    
    public void Walk()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        agent.SetDestination(destination.position);
    }

    
}
