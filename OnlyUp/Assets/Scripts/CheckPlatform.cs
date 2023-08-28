using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlatform : MonoBehaviour
{
    public GameObject mobileUI;
    private void Start()
    {
        if (Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.Android)
            mobileUI.SetActive(true);
        else
            mobileUI.SetActive(false);
    }
}
