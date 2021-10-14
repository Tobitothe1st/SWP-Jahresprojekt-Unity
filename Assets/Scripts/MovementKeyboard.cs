using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementKeyboard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public CharacterController controller;

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
            y = 5;
        }
        else
        {
            move = transform.up * y;
        }

        move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        
    }
}
