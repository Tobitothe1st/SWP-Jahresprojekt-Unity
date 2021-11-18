using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGame : MonoBehaviour
{
    public string currentPosition;
    public Vector3 savePosition;


    void Start()
    {
        SaveSystem.GetVector3(currentPosition);
    }

    // Update is called once per frame
    void Update()
    {
        SaveSystem.SetVector3(currentPosition, savePosition);
    }
}
