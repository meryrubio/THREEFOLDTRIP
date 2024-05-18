using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Bala : MonoBehaviour
{
    public GameObject bala;
    void Update()
    {
        Shoot();
    }
    void Shoot()
    {
        if (Input.GetMouseButtonDown(0)) //boton izquierdo del ratón
        {
            Instantiate(bala, transform.position, Quaternion.identity);
        }

    }
}
