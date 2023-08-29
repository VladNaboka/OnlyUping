using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class CharacterSetController : MonoBehaviour
{
    [SerializeField] private CurrentCharacterData _currentCharacterData;
    private CharacterData _characterData;

    private void OnEnable() 
    {
        CharacterChooseController.onCharacterChoosed += SetCharactersData;
    }

    private void OnDisable() 
    {
        CharacterChooseController.onCharacterChoosed -= SetCharactersData;
    }

    private void SetCharactersData(CharacterData characterSkinData)
    {
        _characterData = characterSkinData;
    }

    public void SetCharacterOnBtnClick()
    {
        gameObject.GetComponent<Image>().color = Color.green;
        _currentCharacterData.SetCurrentCharacterData(_characterData);
        _currentCharacterData.DoCharacterCallback();
    }
}
