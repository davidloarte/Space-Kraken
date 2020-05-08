using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    public float velocidadGiro;

    void Update()
    {
        transform.Rotate(0, velocidadGiro, 0);
    }

}
