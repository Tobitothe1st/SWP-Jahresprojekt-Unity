using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public Transform cam;
    public Vector3 camVector = new Vector3(-4f, 3f, -4f);
    public Vector3 defaultVector = new Vector3(0.2f, 2f, 0.2f);

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("v")&& cam.position != defaultVector)
        {
            cam.position = defaultVector;
        }
        else if(Input.GetKeyDown("v") && cam.position == defaultVector)
        {
            cam.position = camVector;
        }
    }
}
