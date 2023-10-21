using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int speed = 1;
    public int turnSpeed = 1;

    

    //Datos de los inputs.
    float h, v;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InputPlayer();
        Movement();
        Rotate();
    }

    private void InputPlayer()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
    }

    private void Movement()
    {
        transform.Translate(Vector3.forward * v *  speed * Time.deltaTime);
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.up * h * turnSpeed * Time.deltaTime);
    }

    

    
}
