using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int sec = 0;
    private int min = 0;
    private Text timerText;

    public bool start = true;
    public bool deletePrefs = false;

    [SerializeField] private int delta = 0;
    public AudioSource audioSource;
    public float audioPosition;

    private void Start()
    {
        instance = this;
        timerText = GameObject.Find("TimerText").GetComponent<Text>();
        sec = PlayerPrefs.GetInt("sec");
        min = PlayerPrefs.GetInt("min");
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

                PlayerPrefs.SetInt("sec", sec);
                PlayerPrefs.SetInt("min", min);

                if (deletePrefs)
                {
                    PlayerPrefs.DeleteAll();
                    sec = 0;
                    min = 0;
                    timerText.text = min.ToString("D2") + " : " + sec.ToString("D2");
                    deletePrefs = false;
                }

                yield return new WaitForSeconds(1);
            }
        }
    }
}