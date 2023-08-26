using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public bool alwaysShowCursor;

    private bool isPaused = false;
    private CursorLockMode previousLockMode;
    private bool previousCursorVisibility;

    private void Start()
    {
        Resume();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && CanPauseWithEsc())
        {
            if (isPaused)
                Resume();
            else 
                Pause();
        }
    }

    private bool CanPauseWithEsc()
    {

        string currentSceneName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;

        if (currentSceneName == "MainScene")
        {
            return false;
        }

        return true;
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = previousLockMode;

        if (alwaysShowCursor)
            Cursor.visible = true;
        else
            Cursor.visible = false;

        isPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        previousLockMode = Cursor.lockState;
        previousCursorVisibility = Cursor.visible;
        Cursor.visible = true;

        Cursor.lockState = CursorLockMode.None;
        isPaused = true;
    }
}
