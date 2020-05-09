using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Añadimos la libreria que nos permite manejar escenas
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void PlayScene()
    {
        SceneManager.LoadScene("Main Scene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
