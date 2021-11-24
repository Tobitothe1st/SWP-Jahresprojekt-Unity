using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementKeyboard : MonoBehaviour
{
    public CharacterController controller;
    public Transform floor;

    public float speed = 12f;

    public Vector3 move;
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float y = transform.position.y;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 25f;
        }
        else
        {
            speed = 12f;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            move = transform.up + 10f;
        }


        if (Vector3.Distance(controller, floor)>1f)
        {
            move = transform.up - 5f;
        }

        move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);



        
    }
}
