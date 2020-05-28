using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoIndividualAsteroide : MonoBehaviour
{

    private float contador = 0;

    private float velocidad;
    private float alto;
    private float largo;
    private float ancho;

    Vector3 posicion;
    Vector3 Aux;

    Rigidbody asteroide;
    // Start is called before the first frame update
    void Start()
    {
        velocidad = Random.Range(0.0f, 1.0f);
        alto = Random.Range(0.0f, 1.0f);
        largo = Random.Range(0.0f, 1.0f);
        ancho = Random.Range(0.0f, 1.0f);

        //velocidad = 5;
        //alto = 5;
        //largo = 5;
        //ancho = 5;

        posicion = transform.position;

        asteroide = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PausaControl.estaPausado == true)
        {
            asteroide.isKinematic = false;
            Debug.Log("Esta pausado");
        }
        else
        {
            asteroide.isKinematic = true;
            contador += Time.deltaTime * velocidad;

            float x = Mathf.Cos(contador) * ancho;
            //float Y = Mathf.Sin(contador) * alto;
            float z = Mathf.Sin(contador) * largo;
            //float z = 0;


            Aux = transform.position;

            Aux.x += x;
            //Aux.y += Y;
            Aux.z += z;

            transform.position = Aux;
        }
        

    }
}
