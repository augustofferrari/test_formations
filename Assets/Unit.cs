using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Unit : MonoBehaviour
{

    [SerializeField]
    private int position;
    [SerializeField]
    private NavMeshAgent navigationAgent;

    private Transform followPosition;

    

    // Start is called before the first frame update
    void Start()
    {
        navigationAgent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        if(followPosition != null){
            navigationAgent.SetDestination(followPosition.position);
        }
        
    }


    void  AsignPosition(int newPosition, Transform targetPosition){
        position = position;
        followPosition = targetPosition;

    }
}
