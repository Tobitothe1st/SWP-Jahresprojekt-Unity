using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementKeyboard : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float y = 5f;
    public float yspeed = 1f;

    public Vector3 move;



    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");


        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 25f;
        }
        else
        {
            speed = 12f;
        }

        yspeed += Physics.gravity.y * Time.deltaTime;

        if(Input.GetButtonDown("Jump"))
        {
            yspeed = y;
        }
        


        move = transform.right * x + transform.forward * z;
        move.y = yspeed;

        controller.Move(move * speed * Time.deltaTime);

        
    }
}
