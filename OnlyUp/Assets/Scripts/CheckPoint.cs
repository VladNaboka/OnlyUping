using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public bool isPassed = false;
    [SerializeField] private GameObject checkPointParticle;
    public AudioClip checkpointSound;

    private AudioSource audioSource;
    private SpawnPlayer spawnPlayer;


    private void Start()
    {
        spawnPlayer = SpawnPlayer.instance;
        audioSource = GetComponent<AudioSource>();

        if (PlayerPrefs.GetFloat("posx") == spawnPlayer.playerPos.x)
        {
            isPassed = true;
            StartCoroutine("CheckCoroutine");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isPassed)
        {
            isPassed = true;

            Instantiate(checkPointParticle, transform.position, Quaternion.identity);

            if (checkpointSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(checkpointSound);
            }

            PlayerPrefs.SetFloat("posX", gameObject.transform.position.x);
            PlayerPrefs.SetFloat("posY", gameObject.transform.position.y);
            PlayerPrefs.SetFloat("posZ", gameObject.transform.position.z);
            PlayerPrefs.Save();
        }
    }

    IEnumerator CheckCoroutine()
    {
        yield return new WaitForSeconds(1);

        isPassed = false;
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

