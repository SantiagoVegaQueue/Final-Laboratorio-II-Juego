using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    private Vector2 posicion;
    public float movientoVertical;

    public float velocidadVertical;
    public float alturaMaxima;
    public float alturaMinima;

    public int vida = 3;
    private Shake shake;
    public Text vidaPantalla;
    public GameObject gameOver;

    private void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }

    private void Update()
    {
        vidaPantalla.text = vida.ToString();
        if (vida <= 0)
        {
            gameOver.SetActive(true);
            Destroy(gameObject);
        }

        transform.position = Vector2.MoveTowards(transform.position, posicion, velocidadVertical * Time.deltaTime);
        
        if (Input.GetKeyDown(KeyCode.W) && transform.position.y < alturaMaxima)
        {
            shake.CamShake();
            posicion = new Vector2(transform.position.x, transform.position.y + movientoVertical);
          
        }
        if (Input.GetKeyDown(KeyCode.S) && transform.position.y > alturaMinima)
        {
            shake.CamShake();
            posicion = new Vector2(transform.position.x, transform.position.y - movientoVertical);
           
        }

    }
}
