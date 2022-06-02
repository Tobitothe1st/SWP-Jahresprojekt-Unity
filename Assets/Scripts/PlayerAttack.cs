using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject Player;
    Animator a;

    // Start is called before the first frame update
    void Start()
    {
        a = Player.transform.GetChild(0).GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //play Animation
            a.Play("RightHand@Attack01");
        }
    }
}
