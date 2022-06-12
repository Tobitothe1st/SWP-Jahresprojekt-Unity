using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementKeyboard : MonoBehaviour
{
    //ToDo: Fix Clipping

    public CharacterController controller;

    public float speed = 12f;
    public float y = 5f;
    public float yspeed = 1f;

    public Animator a;
    public Vector3 move;



    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //Running

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 25f;
            //a.Play("Run");
        }
        else
        {
            speed = 12f;
            //a.Play("Walk");
        }

        yspeed += Physics.gravity.y * Time.deltaTime;

        //Jumping

        if(Input.GetButtonDown("Jump"))
        {
            yspeed = y;
        }
        

        //Moveing position

        move = transform.right * x + transform.forward * z;
        move.y = yspeed;

        controller.Move(move * speed * Time.deltaTime);

        
    }
}
