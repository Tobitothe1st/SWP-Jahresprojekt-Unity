using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    public Canvas menu;


    public void continueGame()
    {
        //cam1.enabled = !cam1.enabled;
        //cam2.enabled = !cam2.enabled;
        //menu.enabled = !menu.enabled;
        Debug.Log("Continue");
    }

    public void settings()
    {
        Debug.Log("Settings");
    }

    public void quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
