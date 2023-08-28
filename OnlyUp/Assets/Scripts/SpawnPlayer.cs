using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField] private CurrentCharacterData _currentCharacterData;
    private GameObject mobileUI;
    private CharacterData _characterData;
    private GameObject _playerPrefab;
    public static Vector3 playerSpawnPosition = new Vector3(-0.4f, 6.7f, -0.79f);
    public Vector3 playerPos;

    public static SpawnPlayer instance;

    private void Awake()
    {
        instance = this;
        //Cursor.lockState = CursorLockMode.Locked;
        DefinePlayerPrefab();

        if (PlayerPrefs.HasKey("posY") && SceneManager.GetActiveScene().name == "SampleScene")
        {
            Instantiate(_playerPrefab, new Vector3(PlayerPrefs.GetFloat("posX"),
            PlayerPrefs.GetFloat("posY"), PlayerPrefs.GetFloat("posZ")), Quaternion.identity);
            //player.transform.position = playerSpawnPosition;
        }
        else
        {
            Instantiate(_playerPrefab, playerSpawnPosition, Quaternion.identity);
        }
    }

    private void DefinePlayerPrefab()
    {
        _characterData = _currentCharacterData.GetCurrentCharacterData();
        _playerPrefab = _characterData._characterPrefab;
    }

    public void RespawnPlayer()
    {
        _playerPrefab.transform.position = new Vector3(PlayerPrefs.GetFloat("posX"),
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