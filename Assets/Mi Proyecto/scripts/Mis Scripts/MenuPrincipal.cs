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

        //Importante : estas dos lineas hay que comentarlas para que funcione bien el score
        //PlayerPrefs.SetFloat(("Highscore"), 600);
        //PlayerPrefs.SetString(("Name"), "");

        if (PlayerPrefs.GetFloat("Highscore") > 600 || PlayerPrefs.GetFloat("Highscore") <= 0)
            PlayerPrefs.SetFloat(("Highscore"), 600);
       
        if (PlayerPrefs.GetFloat("Highscore") > 0 && PlayerPrefs.GetFloat("Highscore") < 600)
            //Debug.Log(pruebaNombre + " AAA " + pruebaScore);
            textoGanador.text = "El record lo tiene " + PlayerPrefs.GetString("Name").Trim().ToUpper() + " con " + PlayerPrefs.GetFloat("Highscore") + " segundos.";
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
        if (nombre == null || nombre == "")
            nombre = "Kyle";
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
