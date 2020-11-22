﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 posicion;
    public float movientoVertical;
    public float velocidadVertical;
    public float alturaMaxima;
    public float alturaMinima;

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, posicion, velocidadVertical * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < alturaMaxima)
        {
            posicion = new Vector2(transform.position.x, transform.position.y + movientoVertical);
          
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > alturaMinima)
        {
            posicion = new Vector2(transform.position.x, transform.position.y - movientoVertical);
           
        }

    }
}
