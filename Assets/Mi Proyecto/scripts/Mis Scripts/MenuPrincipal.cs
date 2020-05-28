using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Añadimos la libreria que nos permite manejar escenas
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPrincipal : MonoBehaviour
{
    public GameObject Menu;
    public GameObject SaberPanel;
    public GameObject DificultadPanel;

    private Animator menuAnim;
    private Animator saberPanelAnim;
    private Animator dificultadAnim;

    //tienen que ser publicas y estaticas para que las encuentre en controlador
    public static float tiempo = 600f;
    public static string nombre;

    public Text texto;
    public Text textoGanador;
    private void Awake()
    {
        Cursor.visible = true;
        menuAnim = Menu.GetComponent<Animator>();
        saberPanelAnim = SaberPanel.GetComponent<Animator>();
        dificultadAnim = DificultadPanel.GetComponent<Animator>();
        DificultadPanel.SetActive(false);
        //textoGanador.text = "El record lo tiene " + PlayerPrefs.GetString("Name") + " con " + PlayerPrefs.GetFloat("Highscore") + " segundos.";
    }

    public void SaberMas()
    {
        SaberPanel.SetActive(true);

        menuAnim.SetBool("Close", true);
        saberPanelAnim.SetBool("Open", true);

    }

    public void PlayScene()
    {
        nombre = texto.text;
        Debug.Log(nombre);
        SceneManager.LoadScene("Main Scene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Inicio()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Dificultad()
    {
        DificultadPanel.SetActive(true);

        menuAnim.SetBool("Close", true);
        dificultadAnim.SetBool("Open", true);

    }

    public void facil()
    {
        tiempo = 600f;      
    }

    public void medio()
    {
        tiempo = 480f;
    }

    public void dificil()
    {
        tiempo = 360f;
    }
}
