using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            //play Animation
            Debug.Log("Hit");
            Player.transform.GetChild(3).GetComponent<Animator>().Play("RightHand@Attack01");
            //Fix bug only 1 Attack animation playable
        }
    }
}
