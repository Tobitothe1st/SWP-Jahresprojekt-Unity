using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementMouse : MonoBehaviour
{


    public float mouseSensitivity = 100f;

    public Transform playerBody;

    float xRotation = 0f;

    public float maxXNeg = -90f;

    public float maxXPos = 90f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Camera Rotation

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, maxXNeg, maxXPos);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

    }
}
