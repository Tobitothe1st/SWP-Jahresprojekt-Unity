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
    public float stopRange = 2f;
    public float despawnRange = 50f;
    public float ySubtraction = 1.9f;

    private void Start()
    {
    }
    void Update()
    {
        //detects Range 
        Ray ray = new Ray(EnemyBody.transform.position, -transform.up);
        RaycastHit hit = new RaycastHit();
        Physics.Raycast(ray, out hit);
        Debug.DrawRay(EnemyBody.transform.position, -transform.up * 10);
        Debug.Log(hit.distance);
        Vector3 clipToFloor = new Vector3(player.position.x, player.position.y-hit.distance, player.position.z);

        float range = Vector3.Distance(EnemyBody.position, clipToFloor);
        float speed = move * Time.deltaTime;

        //moves if player is in Range
        if (range < detectionRange && range > stopRange)
        {
            EnemyBody.position = Vector3.MoveTowards(EnemyBody.position, clipToFloor, speed);
            Debug.Log(range.ToString());
            //TODO: Enemy Gravity
        }
        if(range > despawnRange)
        {
            //TODO: Despawn Enemy
        }
    }
}
