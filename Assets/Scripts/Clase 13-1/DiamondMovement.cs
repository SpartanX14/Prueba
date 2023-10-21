using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondMovement : MonoBehaviour
{
    public int rotateSpeed = 50;
    public GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
       //gameManager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }


    private void Rotate()
    {
        transform.Rotate(Vector3.forward *  rotateSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            gameManager.AddGems();
        }
    }
}
