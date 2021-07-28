using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
 
    AudioSource sonido;

    void Start()
    {
        sonido = GetComponent<AudioSource>();
        sonido.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
