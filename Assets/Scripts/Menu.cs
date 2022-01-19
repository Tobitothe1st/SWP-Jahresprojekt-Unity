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
        cam1.enabled = !cam1.enabled;
        cam2.enabled = !cam2.enabled;
        menu.enabled = !menu.enabled;
    }

    public void settings()
    {

    }

    public void quit()
    {
        Application.Quit();
    }
}
