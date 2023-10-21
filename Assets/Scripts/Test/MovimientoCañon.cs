using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCañon : MonoBehaviour
{
    public int velocidadMovimientoCañon = 1;
    public int velocidadRotacion = 10;  
  

    // Update is called once per frame
    void Update()
    {
        MovimientoGrupoCañon();

        if (Input.GetKey(KeyCode.RightArrow))
        { RotarCañon(1);}
        else if (Input.GetKey(KeyCode.LeftArrow)) 
        { RotarCañon(-1); }
    }


    void MovimientoGrupoCañon()
    {
        float MovimientoHorizontal = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * MovimientoHorizontal * Time.fixedDeltaTime);

        /*if (Input.GetKey(KeyCode.D))
        { transform.Translate(Vector3.right * MovimientoHorizontal * Time.fixedDeltaTime); }
        if(Input.GetKey(KeyCode.A))
        { transform.Translate(Vector3.right * MovimientoHorizontal * Time.fixedDeltaTime); }*/

        
        //transform.Translate(Vector3.forward * velocidadMovimientoCañon * MovimientoHorizontal);
    }

    void RotarCañon(int direccionRotacion)
    {
        transform.Rotate(Vector3.up * velocidadRotacion * direccionRotacion);
    }
}
