using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropulsorActivation : MonoBehaviour
{
    public ParticleSystem LanzadorParticulas;
    void Start()
    {
        LanzadorParticulas = GetComponent<ParticleSystem>();
        LanzadorParticulas.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            LanzadorParticulas.Play();
        }
        if (Input.GetKeyUp("w"))
        {
            LanzadorParticulas.Stop();
        }

    }
}
