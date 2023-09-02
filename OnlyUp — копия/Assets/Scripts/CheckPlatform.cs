using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using UnityEngine.InputSystem;

public class CheckPlatform : MonoBehaviour
{
    public GameObject mobileUI;
    public PlayerInput plInput;
    private void Start()
    {
        if (Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.Android)
        {
            Debug.Log("A");
            mobileUI.SetActive(true);
            //plInput.uiInputModule = inputSystem;
        }
        else if (Application.platform == RuntimePlatform.WindowsEditor)
        {
            Debug.Log("D");
            mobileUI.SetActive(false);
        }
    }
}
