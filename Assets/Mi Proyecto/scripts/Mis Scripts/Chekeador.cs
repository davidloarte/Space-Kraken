﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chekeador : MonoBehaviour
{
    

    public float cuentaAtras = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        //Hace invisible el cursor mientras juegas
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.Find("SpaceshipFighter_Spear"))
        {
            
            cuentaAtras -= Time.deltaTime;

        }
        if (cuentaAtras <= 0 )
        {
            Cursor.visible = true;
            SceneManager.LoadScene("Failed");
        }
    }
    
}
