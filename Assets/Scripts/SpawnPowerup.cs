using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowerup : MonoBehaviour
{
    public GameObject obj;
    public GameObject powerup;
    void spawnPowerup()
    {
        Vector3 position = new Vector3(obj.transform.position.x, obj.transform.position.y + 1, obj.transform.position.z);
        GameObject newPowerup = Instantiate(powerup);
        newPowerup.transform.position = position;
        newPowerup.SetActive(true);
        obj.GetComponent<AudioSource>().Play();
    }
}