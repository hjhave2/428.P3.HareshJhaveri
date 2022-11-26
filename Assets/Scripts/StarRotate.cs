using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarRotate : MonoBehaviour
{
    public GameObject obj;
    public GameObject reactor1;
    public GameObject reactor2;
    public GameObject reactor3;
    float rotationY;
    public int starNumber;
    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioSource soundEffect;
    void Start()
    {
        rotationY = 50 * Time.deltaTime;
    }
    void Update()
    {
        obj.transform.Rotate(0,rotationY,0);
    }
    void handleStars()
    {
        if(obj.tag == "powerstar")
        {
            rotationY = 0;
            obj.GetComponent<Rigidbody>().useGravity = true;
        }
        if(obj.tag == "grandstar")
        {
            if(starNumber == 1)
            {
                audio1.mute = true;
                audio2.mute = false;
                audio3.mute = true;
                reactor1.SetActive(false);
                reactor2.SetActive(true);
                reactor3.SetActive(false);
            }
            else if(starNumber == 2)
            {
                audio1.mute = true;
                audio2.mute = true;
                audio3.mute = false;
                reactor1.SetActive(false);
                reactor2.SetActive(false);
                reactor3.SetActive(true);
            }
            else
            {
                audio1.mute = false;
                audio2.mute = true;
                audio3.mute = true;
                reactor1.SetActive(true);
                reactor2.SetActive(false);
                reactor3.SetActive(false);
            }
            soundEffect.Play();
        }
    }
}