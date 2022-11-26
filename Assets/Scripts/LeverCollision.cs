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

    void changeMin()
    {
        star.GetComponent<Renderer>().material = material2;
        audio.Play();
    }
    void changeMax()
    {
        star.GetComponent<Renderer>().material = material1;
        audio.Play();
    }
}