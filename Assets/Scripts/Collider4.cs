using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider4 : MonoBehaviour
{
    public int id = 1;
    public Parede4 parede4;

    public void Hited()
    {
        parede4.ColHited(id);
    }
}
