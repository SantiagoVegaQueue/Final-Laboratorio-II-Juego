using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepitingBackground : MonoBehaviour
{
    public float velocidad;
    public float posicioonInicialX;
    public float posicionFinalX;

    private void Update()
    {
        transform.Translate(Vector2.left * velocidad * Time.deltaTime);
        if (transform.position.x < posicionFinalX)
        {
            Vector2 posicion = new Vector2(posicioonInicialX, transform.position.y);
            transform.position = posicion;
        }
    }
}
