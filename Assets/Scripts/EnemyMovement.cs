using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    public Transform EnemyBody;
    public GameObject player;
    public GameObject playerBody;

    public float move = 5f;
    public float detectionRange = 20f;
    public float stopRange = 2f;
    public float despawnRange = 50f;
    public float ySubtraction = 1.9f;

    private void Start()
    {
    }
    void Update()
    {
        //detects Range 

        //find Solution for Enemy not following Player
        Vector3 target = new Vector3(playerBody.Transfrom.position.x, 0f, player.position.z);

        float range = Vector3.Distance(EnemyBody.position, target);
        float speed = move * Time.deltaTime;

        //moves if player is in Range
        if (range < detectionRange && range > stopRange)
        {
            EnemyBody.position = Vector3.MoveTowards(EnemyBody.position, target, speed);
        }
        else if(range > despawnRange)
        {
            Destroy(EnemyBody.gameObject);
        }
    }
}
