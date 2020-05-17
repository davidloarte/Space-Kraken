using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbita1 : MonoBehaviour
{

    private float radioX;
    private float radioY;
    private float radioZ;

    private float puntoY;
    private float puntoX;
    private float puntoZ;

    private Transform centro;

    private float VelocidadRotacion;
    public bool ejeX = false;
    public bool ejeY = false;
    public bool ejeZ = false;
    public bool agujasDeReloj = true;

    private float tiempo = 0;

    Vector3 posicion;
    // Start is called before the first frame update
    void Start()
    {
        VelocidadRotacion = Random.Range(0.005f, 0.05f);
        posicion = transform.position;
        puntoY = posicion.y;
        puntoX = posicion.x;
        puntoZ = posicion.z;

        if (GameObject.Find("Centro"))
        {
            centro = GameObject.Find("Centro").transform;
            radioX = centro.position.x - puntoX;
            radioY = centro.position.y - puntoY;
            radioZ = centro.position.z - puntoZ;
        }
        else
        {
            Debug.Log("centro no encontrado");
        }
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime * VelocidadRotacion * 2;
        Rotar();

    }

    void Rotar()
    {
        if (ejeY)
        {
            //eje Y de centro
            if (agujasDeReloj)
            {
                float x = -Mathf.Cos(tiempo) * radioX;
                float z = Mathf.Sin(tiempo) * radioZ;
                Vector3 posicion = new Vector3(x, puntoY, z);
                transform.position = posicion + centro.position;
            }
            else
            {
                float x = Mathf.Cos(tiempo) * radioX;
                float z = Mathf.Sin(tiempo) * radioZ;
                Vector3 posicion = new Vector3(x, puntoY, z);
                transform.position = posicion + centro.position;
            }
        }
        
        if (ejeZ)
        {
            //eje Z de centro
            if (agujasDeReloj)
            {
                float x = -Mathf.Cos(tiempo) * radioX;
                float y = Mathf.Sin(tiempo) * radioY;
                Vector3 posicion = new Vector3(x, y, puntoZ);
                transform.position = posicion + centro.position;
            }
            else
            {
                float x = Mathf.Cos(tiempo) * radioX;
                float y = Mathf.Sin(tiempo) * radioY;
                Vector3 posicion = new Vector3(x, y, puntoZ);
                transform.position = posicion + centro.position;
            }
        }
        
        if (ejeX)
        {
            if (agujasDeReloj)
            {
                float z = -Mathf.Cos(tiempo) * radioZ;
                float y = Mathf.Sin(tiempo) * radioY;
                Vector3 posicion = new Vector3(puntoX, y, z);
                transform.position = posicion + centro.position;
            }
            else
            {
                float z = Mathf.Cos(tiempo) * radioZ;
                float y = Mathf.Sin(tiempo) * radioY;
                Vector3 posicion = new Vector3(puntoX, y, z);
                transform.position = posicion + centro.position;
            }
        }
    }
}
