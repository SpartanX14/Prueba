using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform posBall;
    private float timer = 0;
    public float timeBetweenAttacks = 2f; //Contador tiempo.

    void Start()
    {
        
    }

    void Update()
    {
        //Contador de tiempo.
        timer += Time.deltaTime;
               
        
        if(Input.GetMouseButtonDown(0) && timer >= timeBetweenAttacks) 
        { 
            timer = 0;
            CreateBall(); 
        }
    }

    void CreateBall()
    {
        GameObject cloneBallPrefab = Instantiate(ballPrefab, posBall.position, posBall.rotation);

        cloneBallPrefab.GetComponent<Ball>().direction = transform.forward;
    }
}
