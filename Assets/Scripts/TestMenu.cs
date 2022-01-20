using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Continue()
    {
        Debug.Log("Continue");
    }

    void Settings()
    {
        Debug.Log("Settings");
    }

    void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
