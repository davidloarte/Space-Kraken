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

    private Animator menuAnim;
    private Animator saberPanelAnim;

    private void Awake()
    {
        menuAnim = Menu.GetComponent<Animator>();
        saberPanelAnim = SaberPanel.GetComponent<Animator>();
    }

    public void SaberMas()
    {
        SaberPanel.SetActive(true);

        menuAnim.SetBool("Close", true);
        saberPanelAnim.SetBool("Open", true);

    }

    public void PlayScene()
    {
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
}
