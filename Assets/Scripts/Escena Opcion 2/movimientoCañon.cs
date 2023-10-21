using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoCañon : MonoBehaviour
{
    public int velocidadAvanzar = 2;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * velocidadAvanzar * Time.fixedDeltaTime);
        MovimientoLateral();
    }

    void MovimientoLateral()
    {
        float MovimientoLateral = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * MovimientoLateral * Time.fixedDeltaTime);
    }
}
