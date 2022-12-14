using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollision : MonoBehaviour
{
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
            collision.collider.gameObject.SetActive(false);
            yield return new WaitForEndOfFrame();
            switch(curObj)
            {
                case 0:
                    obj1.transform.rotation = Quaternion.identity;
                    obj1.transform.position = new Vector3(-0.9f,0,2.8f);
                    break;
                case 1:
                    obj2.transform.rotation = Quaternion.identity;
                    obj2.transform.position = new Vector3(-0.9f,0,2.8f);
                    break;
                case 2:
                    obj3.transform.rotation = Quaternion.identity;
                    obj3.transform.position = new Vector3(-0.9f,0,2.8f);
                    break;
                case 3:
                    obj4.transform.rotation = Quaternion.identity;
                    obj4.transform.position = new Vector3(-0.9f,0,2.8f);
                    break;
            }
            curObj = (curObj+1) % 4;
        }
    }
}
