using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public Transform Enemy;
    public Transform Player;
    public float maxTime;
    public float minTime;
    public float positiveRadius;
    public float negativeRadius;
    int count;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(Enemy.transform.position, -transform.up);
        RaycastHit hit = new RaycastHit();
        Physics.Raycast(ray, out hit);
        //Debug.DrawRay(Enemy.transform.position, -transform.up * 10f, Color.red);

        int randomSpawn = Random.Range(0, 50);
        //Debug.Log(randomSpawn.ToString());
        if (randomSpawn == 25)
        {
            float randomX = Random.Range(negativeRadius, positiveRadius);
            float randomZ = Random.Range(negativeRadius, positiveRadius);
            Vector3 randomPos = new Vector3(Player.position.x - randomX, 10, Player.position.x - randomZ);
            Quaternion zero = new Quaternion(0, 0, 0, 0);
            Enemy = Instantiate(Enemy, randomPos, zero);
            this.Enemy.name = "Enemy " + count;
            count++;
        }
    }
}
