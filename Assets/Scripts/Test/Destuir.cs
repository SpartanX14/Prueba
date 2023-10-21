using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destuir : MonoBehaviour
{
    public int tiempoDestruir = 2;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, tiempoDestruir); 
    }

    

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Destroy(collision.gameObject);
    }

}
