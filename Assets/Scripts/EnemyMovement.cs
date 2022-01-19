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

    //NavMeshAgent agent;
            
    private void Start()
    {
        //agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        Vector3 clipToFloor = new Vector3(player.position.x, player.position.y-1.66f, player.position.z);
        float range = Vector3.Distance(EnemyBody.position, clipToFloor);
        float speed = move * Time.deltaTime;
        //agent.SetDestination(player.position);
        if (range <= detectionRange)
        {
            EnemyBody.position = Vector3.MoveTowards(EnemyBody.position, clipToFloor, speed);
        }
    }
}
