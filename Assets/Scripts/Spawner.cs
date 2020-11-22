using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Enemy;

    private float tiempoEntreAparicion;
    public float inicioTiempoEntreAparicion;
    public float reducirTiempo;
    public float tiempoMinimo = 0.65f;

    private void Update()
    {
        if (tiempoEntreAparicion <= 0)
        {
            int random = Random.Range(0, Enemy.Length);
            Instantiate(Enemy[random], transform.position, Quaternion.identity);
            tiempoEntreAparicion = inicioTiempoEntreAparicion;
            if (inicioTiempoEntreAparicion > tiempoMinimo)
            {
                inicioTiempoEntreAparicion -= reducirTiempo;
            }
            
        }
        else
        {
            tiempoEntreAparicion -= Time.deltaTime;
        }
    }
}
