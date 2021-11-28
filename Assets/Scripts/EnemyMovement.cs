using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    public Transform EnemyBody;
    public Transform player;
    public float move = 5f;
    public float detectionRange = 20f;

    NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {

        float range = Vector3.Distance(EnemyBody.position, player.position);
        float speed = move * Time.deltaTime;
        agent.SetDestination(player.position);
        //if (range <= detectionRange)
        //{
        //    //EnemyBody.position = Vector3.MoveTowards(EnemyBody.position, player.position, speed);

        //}
    }
}
