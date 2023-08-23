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
        if (PlayerPrefs.HasKey("posY"))
        {
            Instantiate(player, new Vector3(PlayerPrefs.GetFloat("posX"),
            PlayerPrefs.GetFloat("posY"), PlayerPrefs.GetFloat("posZ")), Quaternion.identity);
            //player.transform.position = playerSpawnPosition;
        }
        else
        {
            Instantiate(player, playerSpawnPosition, Quaternion.identity);
        }
    }

    public void RespawnPlayer()
    {
        player.transform.position = new Vector3(PlayerPrefs.GetFloat("posX"),
            PlayerPrefs.GetFloat("posY"), PlayerPrefs.GetFloat("posZ"));
    }
    public void ResetPos()
    {
        PlayerPrefs.SetFloat("posX", 0f);
        PlayerPrefs.SetFloat("posY", 6.7f);
        PlayerPrefs.SetFloat("posZ", 0f);
    }
    private void Update()
    {
        playerPos = new Vector3(PlayerPrefs.GetFloat("posX"),
            PlayerPrefs.GetFloat("posY"), PlayerPrefs.GetFloat("posZ"));
    }
}