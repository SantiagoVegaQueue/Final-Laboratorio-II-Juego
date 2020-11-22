using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int daño = 1;
    public float velocidad;

    private void Update()
    {
        transform.Translate(Vector2.left * velocidad * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<Player>().vida -= daño;
            Debug.Log(collision.GetComponent<Player>().vida);
            Destroy(gameObject);
        }
    }
}
