using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static Timer instance;

    private int sec = 0;
    private int min = 0;
    private Text timerText;
    [SerializeField] private int delta = 0;
    
    

    void Start()
    {
        instance = this;
        timerText = GameObject.Find("TimerText").GetComponent<Text>();
        sec = PlayerPrefs.GetInt("sec");
        min = PlayerPrefs.GetInt("min");

        StartCoroutine("ITimer");
    }

    IEnumerator ITimer()
    {
        while (true)
        {
            if(sec == 59)
            {
                min++;
                sec = -1;
            }
            sec += delta;
            timerText.text = min.ToString("D2") + " : " + sec.ToString("D2");
            PlayerPrefs.SetInt("sec", sec);
            PlayerPrefs.SetInt("min", min);
            yield return new WaitForSeconds(1);
        }
    }
}
