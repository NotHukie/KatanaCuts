using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{
    public Rigidbody rb;
    public SpawnManager spawnManager;
    public GameObject parede1;
    public GameObject parede2;
    public GameObject parede3;
    public GameObject parede4;
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        rb.AddForce(0f, 0f, 0.25f);
    }
    
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "SpawnTrigger")
        {
            spawnManager.SpawnTriggerEntered();
            parede1.SetActive(true);
            parede2.SetActive(true);
            parede3.SetActive(true);
            parede4.SetActive(true);
        }
        if(other.gameObject.tag == "Trigger1")
        {
            image1.SetActive(true);
        }
        if (other.gameObject.tag == "Trigger2")
        {
            image2.SetActive(true);
        }
        if (other.gameObject.tag == "Trigger3")
        {
            image3.SetActive(true);
        }
        if (other.gameObject.tag == "Trigger4")
        {
            image4.SetActive(true);
        }

        if (other.gameObject.tag == "Parede")
        {
            SceneManager.LoadScene(2);
        }
    }
}
