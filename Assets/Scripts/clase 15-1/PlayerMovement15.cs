using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement15 : MonoBehaviour
{
    public int speed = 5;
    public GameObject colliderAttack;//referencia al gameobject hijo que tiene el collider trigger

    //Movimiento Transform.
    private Vector3 movement;//Almacena la dirección de movimiento.
    //Datos de los inputs.
    float ejeH, ejeV;
    
    
    //Movimiento por Rigidbody.    
    private Rigidbody rb;

    //Gestion Animaciones.
    Animator anim;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        InputPlayer();
        //MovementTransform();
        Animating();
        Attack();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void InputPlayer()
    {
        ejeH = Input.GetAxis("Horizontal");
        ejeV = Input.GetAxis("Vertical");

        movement = new Vector3(ejeH, 0, ejeV);

        /*
         * Normalizamos el vector para evitar que en diagonal se mueva
         * más rápido. Su modulo vale 1.
         */
       movement.Normalize();
    }

    private void Move()
    {
        rb.MovePosition(transform.position + (movement * speed * Time.deltaTime)); 
    }

    /// <summary>
    /// Movimiento Transform.
    /// </summary>
    void MovementTransform()
    {
        //transform.Translate(Vector3.forward * ejeV *  speed * Time.deltaTime);
        //transform.Translate(Vector3.right * ejeH * speed * Time.deltaTime);

        transform.Translate(movement * speed * Time.deltaTime);
    }

    void Animating()
    {
        if (ejeH != 0 || ejeV != 0)
        {
            anim.SetBool("IsMoving", true);
        }
        else
        {
            anim.SetBool("IsMoving", false);
        }
    }

    void Attack()
    {
        if(Input.GetMouseButtonDown(0) && anim.GetBool("IsMoving") == false)
        {
            anim.SetTrigger("Attack");
        }
    }

    //Se llama desde un evento en la animación.
    void EnableColliderAttack()
    {
        colliderAttack.SetActive(true);
        Invoke("DisableColliderAttack", 0.1f);
    }

    void DisableColliderAttack()
    {
        colliderAttack.SetActive(false);
    }

    


}
