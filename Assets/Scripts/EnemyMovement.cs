using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public Transform EnemyBody;
    public float speed = 10;
    public GameObject player;
    public Vector3 move;


    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        float x = EnemyBody.transform.position.x;
        float y = EnemyBody.transform.position.y;
        float z = EnemyBody.transform.position.z;

        move = transform.right * x + transform.forward * z + transform.up * y;

        if(player.transform.position.x < 0)
        {

        }
    }
}
