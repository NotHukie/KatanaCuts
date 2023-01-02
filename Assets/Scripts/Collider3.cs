using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider3 : MonoBehaviour
{
    public int id = 1;
    public Parede3 parede3;

    public void Hited()
    {
        parede3.ColHited(id);
    }
}
