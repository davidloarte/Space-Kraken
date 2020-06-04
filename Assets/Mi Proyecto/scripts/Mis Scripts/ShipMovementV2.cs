using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovementV2 : MonoBehaviour
{
    private Rigidbody rb;
    public float velocidad;
    public float velocidadMax;
    public GameObject referencia;
    public float velocidadRotar = 0.75f;

    public float velocidadRotacionHorizontal = 1f;
    public float velocidadRotacionVertical = 1f;

    public bool InvertirEjes = false;
    public bool paraAndroid = false;

    public Joystick joystick;
    public GameObject joy;

    public Joystick joystick2;
    public GameObject joy2;
    void Start()
    {
        if (paraAndroid)
        {
            joy.SetActive(true);
            joy2.SetActive(true);
        }     
        else
        {
            joy.SetActive(false);
            joy2.SetActive(false);
        }
           
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moverHorizontal = 0;
        float moverVertical = 0;

        if (paraAndroid)
        {
            if (!InvertirEjes)
            {
                moverHorizontal = joystick.Horizontal;
                moverVertical = joystick.Vertical;
            }
            if (InvertirEjes)
            {
                moverHorizontal = -joystick.Horizontal;
                moverVertical = -joystick.Vertical;
            }
        }
        else
        {
            if (!InvertirEjes)
            {
                moverHorizontal = Input.GetAxis("Horizontal");
                moverVertical = Input.GetAxis("Vertical");
            }
            if (InvertirEjes)
            {
                moverHorizontal = -Input.GetAxis("Horizontal");
                moverVertical = -Input.GetAxis("Vertical");
            }
        }


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
        float h = 0;
        float v = 0;

        if (paraAndroid)
        {
            h = velocidadRotacionHorizontal * joystick2.Horizontal;
            v = velocidadRotacionVertical * joystick2.Vertical;
        }
        else
        {
            if (InvertirEjes)
            {
                h = velocidadRotacionHorizontal * Input.GetAxis("Mouse X");
                v = velocidadRotacionVertical * (Input.GetAxis("Mouse Y"));
            }
            if (!InvertirEjes)
            {
                h = velocidadRotacionHorizontal * Input.GetAxis("Mouse X");
                v = velocidadRotacionVertical * -(Input.GetAxis("Mouse Y"));
            }
        }
        transform.Rotate(v, h, 0);
        
        if (!InvertirEjes) {
            if (Input.GetKey(KeyCode.Q))
                transform.Rotate(new Vector3(0, 0, velocidadRotar));
            if (Input.GetKey(KeyCode.E))
                transform.Rotate(new Vector3(0, 0, -velocidadRotar));
        }

        if (InvertirEjes)
        {
            if (Input.GetKey(KeyCode.E))
                transform.Rotate(new Vector3(0, 0, velocidadRotar));
            if (Input.GetKey(KeyCode.Q))
                transform.Rotate(new Vector3(0, 0, -velocidadRotar));
        }
      
    }
}
