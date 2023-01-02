using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider1 : MonoBehaviour
{
    public int id = 1;
    public Parede1 parede1;

    public void Hited()
    {
        parede1.ColHited(id);
    }
}
