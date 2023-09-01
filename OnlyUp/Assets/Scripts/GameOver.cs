//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;
//using UnityEngine.UI;

//public class GameOver : MonoBehaviour
//{
//    public static GameOver instance;

//    [SerializeField] private Text timeText;
//    [SerializeField] private Text appleText;
//    [SerializeField] private Canvas UI;



//    private void Awake()
//    {
//        instance = this;
//    }

//    private void Start()
//    {
//        GameManager.instance.start = false;
//        GameManager.instance.audioSource.Pause();

//        timeText.text = SceneManager.GetActiveScene().name == "SampleScene" ? PlayerPrefs.GetInt("min").ToString() + ":" + PlayerPrefs.GetInt("sec") : PlayerPrefs.GetInt("min1").ToString() + ":" + PlayerPrefs.GetInt("sec1");
//        appleText.text = PlayerPrefs.GetInt("apple").ToString();
//        UI.enabled = false;
//    }

//    public void MainMenu()
//    {
//        PlayerPrefs.DeleteAll();
//        PlayerPrefs.Save();

//        SceneManager.LoadScene("0");
//    }

//    public void ReturnScene()
//    {
//        PlayerPrefs.DeleteAll();
//        PlayerPrefs.Save();

//        SceneManager.LoadScene("1");
//    }
//}
