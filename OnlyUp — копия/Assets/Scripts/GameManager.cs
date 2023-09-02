using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int sec = 0;
    private int min = 0;
    [SerializeField] private Text timerText;

    public bool start = true;
    public bool deletePrefs = false;

    [SerializeField] private int delta = 0;
    public AudioSource audioSource;
    public float audioPosition;

    [SerializeField] private Text timeText;
    [SerializeField] private Text appleText;
    [SerializeField] private GameObject UI;
    [SerializeField] private GameObject gameOver;


    public bool checkGameOver = false;

    private void Start()
    {
        instance = this;
        

        timerText = GameObject.Find("TimerText").GetComponent<Text>();
        if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            sec = PlayerPrefs.GetInt("sec");
            min = PlayerPrefs.GetInt("min");
        }
        else
        {
            sec = PlayerPrefs.GetInt("sec1");
            min = PlayerPrefs.GetInt("min1");
        }


        audioSource.Play();

        StartCoroutine("ITimer");
    }


    IEnumerator ITimer()
    {
        while (true)
        {
            if (start)
            {
                if (sec == 59)
                {
                    min++;
                    sec = -1;
                }
                sec += delta;
                timerText.text = min.ToString("D2") + " : " + sec.ToString("D2");
                if (SceneManager.GetActiveScene().name == "SampleScene")
                {
                    PlayerPrefs.SetInt("sec", sec);
                    PlayerPrefs.SetInt("min", min);
                }
                else
                {
                    PlayerPrefs.SetInt("sec1", sec);
                    PlayerPrefs.SetInt("min1", min);
                }

                if(checkGameOver)
                {
                    timeText.text = min + ":" + sec;
                    appleText.text = PlayerPrefs.GetInt("appleScore").ToString();
                    UI.SetActive(false);
                    gameOver.SetActive(true);
                    audioSource.Pause();

                    Time.timeScale = 0f;
                    //Cursor.visible = true;

                    Cursor.lockState = CursorLockMode.None;


                    start = false;
                }
                
                if (deletePrefs)
                {
                    PlayerPrefs.DeleteAll();
                    sec = 0;
                    min = 0;
                    timerText.text = min.ToString("D2") + " : " + sec.ToString("D2");
                    deletePrefs = false;
                }
                yield return new WaitForSeconds(1);
            } else
            {
                yield return null;
            }
        }
    }

    public void MainMenu()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();

        SceneManager.LoadScene(0);
    }

    public void ReturnScene()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();

        SceneManager.LoadScene(1);
    }
}