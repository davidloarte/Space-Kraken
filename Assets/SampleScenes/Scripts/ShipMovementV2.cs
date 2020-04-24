using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovementV2 : MonoBehaviour
{
    private Rigidbody rb;
    public float velocidad;
    public float velocidadMax;
    public GameObject referencia;
    
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

    }
}
