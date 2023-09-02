using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using UnityEngine.InputSystem;

public class CheckPlatform : MonoBehaviour
{
    public GameObject mobileUI;
    [SerializeField] PlayerInput plInput;
    private void Start()
    {
        if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            Debug.Log("A");
            mobileUI.SetActive(true);
            plInput.SwitchCurrentControlScheme("Mobile");
        }
        if(Application.platform == RuntimePlatform.Android)
        {
            mobileUI.SetActive(true);
            plInput.SwitchCurrentControlScheme("Mobile");

        }
        if (Application.platform == RuntimePlatform.WindowsEditor)
        {
            Debug.Log("D");
            mobileUI.SetActive(false);
        }
        Debug.Log(Application.platform);
    }
}
