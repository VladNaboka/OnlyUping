using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //SpawnPlayer.playerSpawnPosition = gameObject.transform.position;
            PlayerPrefs.SetFloat("posX", gameObject.transform.position.x);
            PlayerPrefs.SetFloat("posY", gameObject.transform.position.y);
            PlayerPrefs.SetFloat("posZ", gameObject.transform.position.z);
            PlayerPrefs.Save();
        }
    }
}
