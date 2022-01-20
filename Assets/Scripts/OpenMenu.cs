using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenMenu : MonoBehaviour
{

    public Camera cam1;
    public Camera cam2;
    public Canvas menu;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
        menu.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            cam1.enabled = !cam1.enabled;
            cam2.enabled = !cam2.enabled;
            menu.enabled = !menu.enabled;

            //ToDo: Find a way to make Menu work/interactable
            //Player.GetComponent<MovementMouse>().enabled = false;
            
        }
    }
}
