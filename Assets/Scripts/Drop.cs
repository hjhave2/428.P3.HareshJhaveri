using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public AudioSource drop;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        drop.Play();
    }
}
