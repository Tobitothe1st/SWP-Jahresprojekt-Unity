using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public Transform GameObject;
    public Transform player;
    public Vector3 VectorGameObject;
    public CharacterController controllerGameObject;
    public Vector3 move;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Collision.Equals(GameObject, player))
        {
            move.y = move.y + 10;
        }

        controllerGameObject.Move(move * Time.deltaTime);
    }
}
