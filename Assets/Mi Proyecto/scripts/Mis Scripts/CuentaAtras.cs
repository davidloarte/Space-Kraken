using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class CuentaAtras : MonoBehaviour
{
    // en este script utilizamos doubles para poder realizar las divisiones y la funcion Math.Truncate
    double horaActual = 0f;
    double tiempoTotal = 600f;
    double minutosMostrar = 0;
    double segundosMostrar = 0f;

    [SerializeField] Text cuentaAtras;

    // Start is called before the first frame update
    void Start()
    {
        horaActual = tiempoTotal;
    }

    // Update is called once per frame
    void Update()
    {
        horaActual -= 1 * Time.deltaTime;



        minutosMostrar = Math.Truncate( horaActual / 60);
        segundosMostrar = horaActual % 60;
        cuentaAtras.text = minutosMostrar.ToString("0") + ":" + segundosMostrar.ToString("0.0");
        //cuentaAtras.text = horaActual.ToString("0.0");

        if (horaActual <= 100)
        {
            cuentaAtras.color = Color.red;
        }
        if (horaActual <= 0)
        {
            horaActual = 0;
            Cursor.visible = true;
            SceneManager.LoadScene("Failed");
        }
    }
}
