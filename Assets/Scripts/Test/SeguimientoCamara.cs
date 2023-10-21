using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    public Transform objetivoCamara;    

    
    void Update()
    {
        transform.LookAt(objetivoCamara);        
    }
}
