using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public static Vector3 playerSpawnPosition = new Vector3(-0.4f, 6.7f, -0.79f);
    public Vector3 playerPos;
    public GameObject player;

    private void Awake()
    {
        if (playerSpawnPosition != null)
        {
            Instantiate(player, new Vector3(PlayerPrefs.GetFloat("posX"),
            PlayerPrefs.GetFloat("posY"), PlayerPrefs.GetFloat("posZ")), Quaternion.identity);
            //player.transform.position = playerSpawnPosition;
        }
        //player.transform.position = new Vector3(PlayerPrefs.GetFloat("posX"),
        //    PlayerPrefs.GetFloat("posY"), PlayerPrefs.GetFloat("posZ"));
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
        //player.transform.position = new Vector3(PlayerPrefs.GetFloat("posX"), 
        //    PlayerPrefs.GetFloat("posY"), PlayerPrefs.GetFloat("posZ"));
    }
    private void Update()
    {
        playerPos = new Vector3(PlayerPrefs.GetFloat("posX"),
            PlayerPrefs.GetFloat("posY"), PlayerPrefs.GetFloat("posZ"));
    //    playerPos = new Vector3(PlayerPrefs.GetFloat("posX"),
    //PlayerPrefs.GetFloat("posY"), PlayerPrefs.GetFloat("posZ"));
    }
}
