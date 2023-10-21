using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escena2Disparo : MonoBehaviour
{
    public int velocidadProyectil = 1500;
    public GameObject prefabProyectil;
    public Transform origenProyectil;
    int dispararActivo = 5;
    public int frecuenciaDisparo = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        { Disparar(); }
    }

    private void Disparar()
    {
        Debug.Log("Disparar = " + dispararActivo);
        Rigidbody rb_Proyectil;
        
        if (dispararActivo >= frecuenciaDisparo)
        {
            rb_Proyectil = Instantiate(prefabProyectil, origenProyectil.position, origenProyectil.rotation).GetComponent<Rigidbody>();
            rb_Proyectil.AddForce(transform.forward * velocidadProyectil);

            dispararActivo = 0;
        }
       
        dispararActivo += 1;
    }
}
