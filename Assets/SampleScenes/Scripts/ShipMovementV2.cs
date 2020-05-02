using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovementV2 : MonoBehaviour
{
    private Rigidbody rb;
    public float velocidad;
    public float velocidadMax;
    public GameObject referencia;

    public float velocidadRotacionHorizontal = 1f;
    public float velocidadRotacionVertical = 1f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moverHorizontal = Input.GetAxis("Horizontal");
        float moverVertical = Input.GetAxis("Vertical");
        
        if (rb.velocity.magnitude > velocidadMax)
        {
            rb.velocity = rb.velocity.normalized * velocidadMax;
        }

        rb.AddForce(moverHorizontal * referencia.transform.right * velocidad);
        rb.AddForce(moverVertical * referencia.transform.forward * velocidad);
        //para arriba y abajo hay no hay ejes predefinidos
        if (Input.GetKey(KeyCode.Space))
            rb.AddForce(referencia.transform.up * velocidad, ForceMode.Force);
        if (Input.GetKey(KeyCode.LeftShift))
            rb.AddForce(referencia.transform.up * (-velocidad), ForceMode.Force);

        rotar();
    }

    public void rotar()
    {

        float h = velocidadRotacionHorizontal * Input.GetAxis("Mouse X");
        float v = velocidadRotacionVertical * -(Input.GetAxis("Mouse Y"));
        transform.Rotate(v, h, 0);

        //if (Input.GetAxis("Mouse X") > 0) 
        //{ 
        //    Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 2, Vector3.up);

        //}

        //if (Input.GetAxis("Mouse X") < 0)
        //{ 
        //    rb.AddTorque(transform.right * 1f, ForceMode.Force);

        //}

        ////descarto poner el eje z porque no se puede mover el mouse en el
        //distancia = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 2, Vector3.up) /** Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * 2, Vector3.forward) */* distancia;
        ////distancia = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * 2, Vector3.forward) * distancia;
        ////distancia = Quaternion.AngleAxis(Input.GetAxis("Mouse Z") * 2, Vector3.right) * distancia;

        //transform.position = jugador.transform.position + distancia;
        //transform.LookAt(jugador.transform.position);

        //// Usamos referencia para que nuestros controles no varien
        ////Vector3 copiaRotacion = new Vector3(0, transform.eulerAngles.y, 0);
        //Vector3 copiaRotacion = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);
        //referencia.transform.eulerAngles = copiaRotacion;
    }
}
