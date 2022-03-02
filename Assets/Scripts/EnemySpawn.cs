using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public Object Enemy;
    public Transform Player;
    public float maxTime;
    public float minTime;
    public float positiveRadius;
    public float negativeRadius;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float randomX = Random.Range(negativeRadius, positiveRadius);
        float randomZ = Random.Range(negativeRadius, positiveRadius);
        Vector3 randomPos = new Vector3(Player.position.x - randomX, 50, Player.position.x - randomZ);
        Quaternion zero = new Quaternion(0, 0, 0, 0);
        Enemy = Instantiate(Enemy, randomPos, zero);
    }
}
