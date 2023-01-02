using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parede4 : MonoBehaviour
{
    public bool col1 = false;
    public bool col2 = false;
    public bool col3 = false;
    public bool col4 = false;
    public GameObject image4;

    public GameObject parede4;

    public GameObject audioWall;
    public GameObject audioAttack;
    public bool triggerSounds = false;
    public float timer;
    public float timeEncreasedPerSec = 1f;

    void Update()
    {
        if (col1 && col2 && col3 && col4)
        {
            parede4.SetActive(false);
            image4.SetActive(false);
            col1 = false;
            col2 = false;
            col3 = false;
            col4 = false;
        }
    }
    public void ColHited(int id)
    {
        if (id == 1)
        {
            col1 = true;
        }
        if (id == 2)
        {
            col2 = true;
        }
        if (id == 3)
        {
            col3 = true;
        }
        if (id == 4)
        {
            col4 = true;
        }
    }
}
