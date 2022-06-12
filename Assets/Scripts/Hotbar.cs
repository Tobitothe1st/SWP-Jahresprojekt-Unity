using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hotbar : MonoBehaviour
{
    public GameObject[] Weapons;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject g in Weapons)
        {
            g.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach(GameObject g in Weapons)
            {
                g.SetActive(false);
            }
            Weapons[0].SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (GameObject g in Weapons)
            {
                g.SetActive(false);
            }
            Weapons[1].SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            foreach (GameObject g in Weapons)
            {
                g.SetActive(false);
            }
            Weapons[2].SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            foreach (GameObject g in Weapons)
            {
                g.SetActive(false);
            }
            Weapons[3].SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            foreach (GameObject g in Weapons)
            {
                g.SetActive(false);
            }
            Weapons[4].SetActive(true);
        }
    }
}
