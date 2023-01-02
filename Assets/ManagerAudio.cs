using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerAudio : MonoBehaviour
{
    public Parede1 parede1;
    public Parede2 parede2;
    public Parede3 parede3;
    public Parede4 parede4;

    public GameObject audioWall;
    public GameObject audioKatana;

    public bool sound = false;
    public bool soundDisable = false;

    public float timer = 0f;
    public float timeEncreasedPerSec = 1f;

    void Update()
    {

        if(parede1.col1 && parede1.col2 && parede1.col3 && parede1.col4)
        {
            audioKatana.SetActive(true);
            audioWall.SetActive(true);
            sound = true;
        }
        if (parede2.col1 && parede2.col2 && parede2.col3 && parede2.col4)
        {
            audioKatana.SetActive(true);
            audioWall.SetActive(true);
            sound = true;
        }
        if (parede3.col1 && parede3.col2 && parede3.col3 && parede3.col4)
        {
            audioKatana.SetActive(true);
            audioWall.SetActive(true);
            sound = true;
        }
        if (parede4.col1 && parede4.col2 && parede4.col3 && parede4.col4)
        {
            audioKatana.SetActive(true);
            audioWall.SetActive(true);
            sound = true;
        }
        if(sound)
        {
            timer += timeEncreasedPerSec * Time.deltaTime;
            soundDisable = true;
        }
        if(soundDisable && timer >= 1f)
        {
            sound = false;
            soundDisable = false;
            timer = 0f;
            audioKatana.SetActive(false);
            audioWall.SetActive(false);
        }
    }
}
