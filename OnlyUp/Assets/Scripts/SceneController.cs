using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void OpenUI(GameObject objectToOpen)
    {
        objectToOpen.SetActive(true);
    }
    public void CloseUI(GameObject objectToClose)
    {
        objectToClose.SetActive(false);
    }
    public void OpenURL(string url)
    {
        Application.OpenURL(url);
    }
}
