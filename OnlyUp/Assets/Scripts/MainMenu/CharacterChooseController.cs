using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterChooseController : MonoBehaviour
{
    [SerializeField] private CharacterData _characterData;

    public static event Action<CharacterData> onCharacterChoosed;

    [SerializeField] private GameObject btnExelent;
    public void ChooseCharacterOnBtnClick()
    {
        btnExelent.GetComponent<Image>().color = Color.white;
        Debug.Log(_characterData.name);
        onCharacterChoosed?.Invoke(_characterData);
    }
}
