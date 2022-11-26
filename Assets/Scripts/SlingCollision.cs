using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SlingCollision : MonoBehaviour
{
    public GameObject obj;
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public UnityEvent OnEnter;
    void Start()
    {

    }
    void Update()
    {
        float x = obj.transform.position.x;
        float z = obj.transform.position.z;
        if((x < minX) || (x > maxX))
        {
            return;
        }
        if((z < minZ) || (z > maxZ))
        {
            return;
        }
        OnEnter.Invoke();
    }
}