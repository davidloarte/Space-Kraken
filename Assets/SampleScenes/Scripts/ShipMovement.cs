using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    float vrotacion = 4f;
    public Rigidbody rb;
    public Renderer rend;

    // para poder cambiar el color
    public Color color;
    // Start is called before the first frame update
    void Start()
    {
        rend = this.GetComponent<Renderer>();
        rend.material.color = color;
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rotar();
        movimiento();
        controlDireccion();
    }

    public void rotar()
    {
        if (Input.GetKey(KeyCode.Q))
            rb.AddTorque(transform.forward * -1f, ForceMode.Force);
        if (Input.GetKey(KeyCode.E))
            rb.AddTorque(transform.forward * 1f, ForceMode.Force);
    }

    public void movimiento()
    {
        if (Input.GetKey(KeyCode.W))
           rb.AddForce(Vector3.forward * 5f, ForceMode.Force);
        if (Input.GetKey(KeyCode.S))
            rb.AddForce(Vector3.back * 5f, ForceMode.Force);
        if (Input.GetKey(KeyCode.A))
            rb.AddForce(Vector3.left * 3f, ForceMode.Force);
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(Vector3.right * 3f, ForceMode.Force);
        if (Input.GetKey(KeyCode.Space))
            rb.AddForce(Vector3.up * 3f, ForceMode.Force);
        if (Input.GetKey(KeyCode.LeftShift))
            rb.AddForce(Vector3.down * 3f, ForceMode.Force);
    }

    public void controlDireccion()
    {




        //Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        //float puntoMedio = (transform.position - Camera.main.transform.position).magnitude * 0.5f;

        //transform.LookAt(mouseRay.origin + mouseRay.direction * puntoMedio);
    }
}
