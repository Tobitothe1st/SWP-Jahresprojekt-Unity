using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public Transform EnemyBody;
    public Transform player;
    public float move = 5f;
    public float detectionRange = 20f;

    void Update()
    {

        float range = Vector3.Distance(EnemyBody.position, player.position);
        float speed = move * Time.deltaTime;

        if (range <= detectionRange)
        {
                EnemyBody.position = Vector3.MoveTowards(EnemyBody.position, player.position, speed);
        }
    }
}
