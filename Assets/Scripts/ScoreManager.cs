using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int puntaje;
    public Text puntajePantalla;

    private void Update()
    {
        puntajePantalla.text = puntaje.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            puntaje++;
            Debug.Log(puntaje);
        }
    }
}
