using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausaControl : MonoBehaviour
{

    public static bool estaPausado = false;

    public GameObject menuPausaUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (estaPausado)
            {
                reanudar();
            }
            else
            {
                pausar();
            }
        }
    }

    // es publica porque necesitamos llamarla con el boton
    public void reanudar()
    {
        menuPausaUI.SetActive(false);
        //para parar el tiempo de juego se utiliza esta funcion
        //A demas para reanudarlo se pone a 1
        // Con esta funcion tambien se pueden hacer camaras lentas
        Time.timeScale = 1f;
        estaPausado = false;
    }

    private void pausar()
    {
        menuPausaUI.SetActive(true);
        Time.timeScale = 0f;
        estaPausado = false;
    }

    public void CargarMenu()
    {
        //Al haber pausado el juego sigue parado por eso tenemos que reanudarlo antes de cargar el menu
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void Salir()
    {
        Application.Quit();
    }
}
