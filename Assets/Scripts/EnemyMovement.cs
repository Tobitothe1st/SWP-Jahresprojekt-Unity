using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    public GameObject EnemyBody;
    public Transform playerBody;

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
        Vector3 target = new Vector3(playerBody.position.x, 0f, playerBody.position.z);

        float range = Vector3.Distance(EnemyBody.transform.position, target);
        float speed = move * Time.deltaTime;
        Transform Body = EnemyBody.transform.GetChild(1);

        //moves if player is in Range
        if (range < detectionRange && range > stopRange)
        {
            EnemyBody.transform.position = Vector3.MoveTowards(EnemyBody.transform.position, target, speed);
            //Look at Player, prevent from falling (set values to 0)
            EnemyBody.transform.LookAt(target);
            EnemyBody.transform.GetChild(1).GetComponent<Animator>().Play("Z_Run 1");
        }
        else if((range > despawnRange || Body.transform.position.y <= -20) && EnemyBody.name != "Enemey")
        {
            EnemyBody.SetActive(false);
            EnemyBody.transform.GetChild(1).GetComponent<Animator>().Play("Z_Idle 1");
        }
        else if(range <= stopRange)
        {
            int randomAttack = Random.Range(0, 100);
            if(randomAttack == 50)
            {
                EnemyBody.transform.GetChild(1).GetComponent<Animator>().Play("Z_Attack 1");
            }
        }
    }
}
