using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class CuentaAtras : MonoBehaviour
{
    // en este script utilizamos doubles para poder realizar las divisiones y la funcion Math.Truncate
    public static double horaActual = 0f;
    double tiempoTotal;
    double minutosMostrar = 0;
    double segundosMostrar = 0f;

    MenuPrincipal menu;

    [SerializeField] Text cuentaAtras;

    public GameObject mirilla;

    // Start is called before the first frame update
    void Start()
    {
        // cogemos los valores de tiempo total que se han selecionado en el menu de dificultad
        tiempoTotal = controlador.tiempo2;
        if (tiempoTotal == 0)
            tiempoTotal = 600f;

        horaActual = tiempoTotal;
        mirilla.SetActive(true);
      
    }

    // Update is called once per frame
    void Update()
    {
        horaActual -= 1 * Time.deltaTime;



        minutosMostrar = Math.Truncate( horaActual / 60);
        segundosMostrar = horaActual % 60;
        cuentaAtras.text = minutosMostrar.ToString("0") + ":" + segundosMostrar.ToString("0.0");
        //cuentaAtras.text = horaActual.ToString("0.0");

        if (horaActual <= 180)
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
