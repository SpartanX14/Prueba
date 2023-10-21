using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoCañon : MonoBehaviour
{
    public GameObject proyectil;
    public Transform origenProyectil;
    public int velocidadProyectil = 3000;
    Rigidbody brProyectil;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Disparar();
    }

    private void Disparar()
    {
        Debug.Log("Click sobre el cañón...");
        brProyectil = Instantiate(proyectil,origenProyectil.position, origenProyectil.rotation).GetComponent<Rigidbody>();
        brProyectil.AddForce(transform.forward * velocidadProyectil);
    }
}
