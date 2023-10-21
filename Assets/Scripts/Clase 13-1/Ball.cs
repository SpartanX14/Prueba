using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
/// <summary>
/// Gestiona la fuerza de la impulso de la bola.
/// </summary>
public class Ball : MonoBehaviour
{
    Rigidbody rb;
    public float force = 1;
    public Vector3 direction = Vector3.forward;
    public float timeToDestroy = 2f;
    public Material newEnemyMaterial;//1
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(direction * force);

        Destroy(gameObject, timeToDestroy); 
    }

    
    void Update()
    {
        
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            //Destroy(collision.gameObject);
            collision.gameObject.GetComponent<MeshRenderer>().material = newEnemyMaterial;
            
            Destroy(gameObject);
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<MeshRenderer>().material = newEnemyMaterial;   
    }
}
