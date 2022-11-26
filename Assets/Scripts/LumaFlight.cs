using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LumaFlight : MonoBehaviour
{
    // Start is called before the first frame update
    float min;
    float max;
    void Start()
    {
        min=transform.position.x;
        max=transform.position.x+23;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =new Vector3(Mathf.PingPong(Time.time*2,max-min)+min, transform.position.y, transform.position.z);
    }
}