using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public float tiempoVida;

    private void Start()
    {
        Destroy(gameObject, tiempoVida);
    }
}
