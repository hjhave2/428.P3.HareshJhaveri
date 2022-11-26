using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeverCollision : MonoBehaviour
{
    public GameObject star;
    public Material material1;
    public Material material2;
    public AudioSource audio;
    public UnityEvent value;

    void changeMaterial()
    {
        if(star.GetComponent<Renderer>().sharedMaterial == material1)
        {
            star.GetComponent<Renderer>().material = material2;
        }
        else
        {
            star.GetComponent<Renderer>().material = material1;
        }
        audio.Play();
    }
}