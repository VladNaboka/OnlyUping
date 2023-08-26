using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private bool isPassed = false;
    public AudioClip checkpointSound;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isPassed)
        {
            isPassed = true;

            if (checkpointSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(checkpointSound);
            }

            // Save checkpoint as passed
            PlayerPrefs.SetInt(gameObject.GetInstanceID().ToString(), 1);
            PlayerPrefs.SetFloat("posX", gameObject.transform.position.x);
            PlayerPrefs.SetFloat("posY", gameObject.transform.position.y);
            PlayerPrefs.SetFloat("posZ", gameObject.transform.position.z);
            PlayerPrefs.Save();
        }
    }


    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Player"))
    //    {
    //        //SpawnPlayer.playerSpawnPosition = gameObject.transform.position;
    //        PlayerPrefs.SetFloat("posX", gameObject.transform.position.x);
    //        PlayerPrefs.SetFloat("posY", gameObject.transform.position.y);
    //        PlayerPrefs.SetFloat("posZ", gameObject.transform.position.z);
    //        PlayerPrefs.Save();
    //    }
    //}

}

