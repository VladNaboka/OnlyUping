using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField] private Vector3 playerPos;
    public GameObject player;
    private bool isFirstTime = true;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("HasSceneBeenStarted"))
        {
            isFirstTime = false;
        }
        else
        {
            PlayerPrefs.SetInt("HasSceneBeenStarted", 1);
            Instantiate(player, new Vector3(PlayerPrefs.GetFloat("posX"),
                PlayerPrefs.GetFloat("posY"), PlayerPrefs.GetFloat("posZ")), Quaternion.identity);
            PlayerPrefs.Save();
        }

        if (isFirstTime)
        {
            SetInitialPosition();
        }
        
    }

    private void SetInitialPosition()
    {
        PlayerPrefs.SetFloat("posX", playerPos.x);
        PlayerPrefs.SetFloat("posY", playerPos.y);
        PlayerPrefs.SetFloat("posZ", playerPos.z);
        PlayerPrefs.Save();
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Checkpoint"))
    //    {
    //        playerSpawnPosition = other.gameObject.transform.position;
    //        //PlayerPrefs.SetFloat("posX", other.gameObject.transform.position.x);
    //        //PlayerPrefs.SetFloat("posY", other.gameObject.transform.position.y);
    //        //PlayerPrefs.SetFloat("posZ", other.gameObject.transform.position.z);
    //        //PlayerPrefs.Save();
    //    }
    //}

    public void RespawnPlayer()
    {
        Debug.Log("new pos");
        player.transform.position = new Vector3(PlayerPrefs.GetFloat("posX"),
            PlayerPrefs.GetFloat("posY"), PlayerPrefs.GetFloat("posZ"));
    }
    private void Update()
    {
        playerPos = new Vector3(PlayerPrefs.GetFloat("posX"),
            PlayerPrefs.GetFloat("posY"), PlayerPrefs.GetFloat("posZ"));
    }
}
