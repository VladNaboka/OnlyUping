using Cinemachine;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    private GameObject cameraMove;
    private bool isPaused = false;

    private void Awake()
    {
        cameraMove = GameObject.FindGameObjectWithTag("CameraMove");
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                Resume();
            else
                Pause();
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        cameraMove.SetActive(true);
        Time.timeScale = 1f;
        //Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        isPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        cameraMove.SetActive(false);
        Time.timeScale = 0f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None; 
        isPaused = true;
    }
}
