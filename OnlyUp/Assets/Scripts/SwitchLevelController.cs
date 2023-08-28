using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwitchLevelController : MonoBehaviour
{
    public GameObject[] slides;
    public Button nextButton;
    public Button prevButton;

    public Image btnColor;

    private int currentSlideIndex = 0;

    private void Start()
    {
        ShowSlide(currentSlideIndex);
        UpdateButtonStates();
    }

    public void NextSlide()
    {
        currentSlideIndex++;
        ShowSlide(currentSlideIndex);
        UpdateButtonStates();
    }

    public void PreviousSlide()
    {
        currentSlideIndex--;
        ShowSlide(currentSlideIndex);
        UpdateButtonStates();
    }

    public void PlayLoadScene()
    {
        if (currentSlideIndex == 0)
        {
            SceneManager.LoadScene("SampleScene");
        }

        if (currentSlideIndex == 1 && PlayerPrefs.GetInt("Win1Level") == 1)
        {
            SceneManager.LoadScene("SampleScene2");
        }
    }

    private void ShowSlide(int index)
    {
        for (int i = 0; i < slides.Length; i++)
        {
            slides[i].SetActive(i == index);
        }
    }

    private void UpdateButtonStates()
    {
        nextButton.interactable = currentSlideIndex < slides.Length - 1;
        prevButton.interactable = currentSlideIndex > 0;
        print(currentSlideIndex);
    }

    private void Update()
    {
        if (currentSlideIndex == 0)
            btnColor.color = Color.white;
        else if (PlayerPrefs.GetInt("Win1Level") == 0)
            btnColor.color = Color.gray;
        else
            btnColor.color = Color.white;

    }
}
