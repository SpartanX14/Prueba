using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform objetivoCamara;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.forward * objetivoCamara.position.z) = objetivoCamara.transform.position.z;
        transform.position = new Vector3(objetivoCamara.position.x, 10f, objetivoCamara.position.z - 20);
    }
}
