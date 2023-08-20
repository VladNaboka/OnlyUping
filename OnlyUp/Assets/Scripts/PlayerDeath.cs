using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] private SpawnPlayer spawnPlayer;
    [SerializeField] private GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Death");
        SceneManager.LoadScene(0, LoadSceneMode.Single);
        other.GetComponent<SpawnPlayer>().RespawnPlayer();
    }
}
