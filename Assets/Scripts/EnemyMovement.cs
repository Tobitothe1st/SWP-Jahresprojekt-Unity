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
        Debug.DrawRay(EnemyBody.transform.position, -transform.up * 10f, Color.red);
        //Debug.Log(hit.distance);
        Vector3 target = new Vector3(player.position.x, 0f, player.position.z);

        float range = Vector3.Distance(EnemyBody.position, target);
        float speed = move * Time.deltaTime;

        //moves if player is in Range
        if (range < detectionRange && range > stopRange)
        {
            EnemyBody.position = Vector3.MoveTowards(EnemyBody.position, target, speed);
            EnemyBody.LookAt(player);
            //EnemyBody.LookAt(player);
            //if(EnemyBody.rotation.x != 0 || EnemyBody.rotation.z != 0)
            //{
            //    EnemyBody.Rotate(0, 0, 0);
            //}
            //Debug.Log(EnemyBody.rotation);
            //Debug.Log(range.ToString());
            //TODO: Enemy Gravity
        }
        if(range > despawnRange)
        {
            //TODO: Despawn Enemy
        }
    }
}
