using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public int appleScore = 0;
    public Text appleText;


    private void Awake()
    {
        if (PlayerPrefs.HasKey("Apples"))
        {
            appleScore = PlayerPrefs.GetInt("Apples");
        }
    }
    void Update()
    {
        appleText.text = "яблок: " + appleScore.ToString();
    }

    public void AddApple(int amount)
    {
        appleScore += amount;
        PlayerPrefs.SetInt("Apples", appleScore);
    }
}
