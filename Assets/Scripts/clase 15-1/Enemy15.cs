using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy15 : MonoBehaviour
{
    GameObject player;//referencia al objetivo.

    NavMeshAgent agent;
    Animator anim;
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();   
        anim = GetComponent<Animator>();
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
        Animating();
    }
      

    void Animating()
    {
        if (agent.velocity.magnitude != 0)
            anim.SetBool("IsMoving", true);
        else
        {
            anim.SetBool("IsMoving", false);
            //anim.SetTrigger("Attack");
        }
    }
}
