using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider2 : MonoBehaviour
{
    public int id = 1;
    public Parede2 parede2;

    public void Hited()
    {
        parede2.ColHited(id);
    }
}
