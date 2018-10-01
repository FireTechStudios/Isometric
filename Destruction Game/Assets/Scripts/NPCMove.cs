using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCMove : MonoBehaviour {

    public bool playerIsClose;
    public Vector3 originalPosition;

    [SerializeField]
    Transform _destination;

    NavMeshAgent _navMeshAgent;

    void Start()
    {
        playerIsClose = false;
        _navMeshAgent = this.GetComponent<NavMeshAgent>();
        originalPosition = this.gameObject.transform.position;
    }

    // Use this for initialization
    void Update () {
        if (playerIsClose == true)
        {
            if (_navMeshAgent == null)
            {
                Debug.LogError("The nav mesh agent component is not attatched to " + gameObject.name);

            }
            else
            {
                SetDestination();
            }
        }
        else
        {
            GoBackHome();
        }

	}

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            playerIsClose = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerIsClose = false;
        }
    }

    private void SetDestination()
    {
        if(_destination != null)
        {
            Vector3 targetVector = _destination.transform.position;
            _navMeshAgent.SetDestination(targetVector);
        }
    }

    private void GoBackHome()
    {
        if (_destination != null)
        {
            Vector3 targetVector = originalPosition;
            _navMeshAgent.SetDestination(targetVector);
        }
    }
}
