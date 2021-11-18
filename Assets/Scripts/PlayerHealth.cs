using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public Transform PlayerBody;
    public Transform EnemyBody;
    public float Health = 100f;
    public Vector3 spawn = new Vector3(0f, 0f, 0f);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Collision.Equals(PlayerBody, EnemyBody))
        {
            Health = Health - 10f;
        }

        if(Health <= 0)
        {
            PlayerBody.position = spawn;
        }
    }
}
