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
    public void ChooseCharacterOnBtnClick(Color colorButton)
    {
        btnExelent.GetComponent<Image>().color = colorButton;
        Debug.Log(_characterData.name);
        onCharacterChoosed?.Invoke(_characterData);
    }
    public void BuyCharacter(int apples)
    {
        if (PlayerPrefs.GetInt("Apples") >= apples && apples != 0)
        {
            PlayerPrefs.SetInt("Apples", PlayerPrefs.GetInt("Apples") - apples);
            ChooseCharacterOnBtnClick(Color.white);
        }
        else if (PlayerPrefs.GetInt("Apples") < apples && apples != 0)
        {
            ChooseCharacterOnBtnClick(Color.red);
            btnExelent.GetComponentInChildren<Text>().text = apples + " яблок";
        }

        if (apples == 0)
        {
            ChooseCharacterOnBtnClick(Color.white);
            btnExelent.GetComponentInChildren<Text>().text = "Выбрать";
        }
    }
}
