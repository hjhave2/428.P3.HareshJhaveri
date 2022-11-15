using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollision : MonoBehaviour
{
    public AudioSource ding;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    int curObj;
    // Start is called before the first frame update
    void Start()
    {
        curObj = 0;
    }
    IEnumerator OnCollisionEnter(Collision collision)
    {
        if(collision.collider.gameObject.tag == "Coin")
        {
            Destroy(collision.collider.gameObject);
            yield return new WaitForEndOfFrame();
            switch(curObj)
            {
                case 0:
                    obj1.transform.position = new Vector3(0,1.5f,-0.5f);
                    break;
                case 1:
                    obj2.transform.position = new Vector3(0,1.5f,-0.5f);
                    break;
                case 2:
                    obj3.transform.position = new Vector3(0,1.5f,-0.5f);
                    break;
                case 3:
                    obj4.transform.position = new Vector3(0,1.5f,-0.5f);
                    break;
            }
            curObj = (curObj+1) % 4;
            ding.Play();
        }
    }
}
