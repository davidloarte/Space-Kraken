using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    //lo iniciamos como objeto del juego
    public GameObject ship;

    //añadimos la distancia a la que estara la camara
    //vector 3 porque es en 3d
    private Vector3 espacio;

    // Start is called before the first frame update
    void Start()
    {
        espacio = transform.position - ship.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ship.transform.position + espacio;
    }
}
