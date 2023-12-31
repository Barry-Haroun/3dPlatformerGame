using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] private NavMeshAgent enemy;
    [SerializeField] private Transform position1;
    [SerializeField] private Transform position2;

    private Vector3 currentTarget;
    void Start()
    {
        enemy.SetDestination(position1.position);
        currentTarget = position1.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy.remainingDistance < 0.35f)
        {
            if (currentTarget == position1.position)
            {
                currentTarget = position2.position;
            }
            else
            {
                currentTarget = position1.position;
            }
            enemy.SetDestination(currentTarget);
        }
       
    }
}