using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject Player;
    
    // Start is called before the first frame update
    void Start()
    {


    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            //Debug.Log("Hit");
        }
        else if (col.gameObject.tag == "Player")
        {
            //Debug.Log("Hit2");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
