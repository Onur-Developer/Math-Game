using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket2 : MonoBehaviour
{
    private ParticleSystem p;

    private void Start()
    {
        p = GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            p.Stop();
        }
    }

    private void OnParticleTrigger()
    {
        Debug.Log("carpıstı");
    }

    private void OnParticleSystemStopped()
    {
        Debug.Log("Fonksiyon Çalıştı");
    }
}
