using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChooseController : MonoBehaviour
{
    [SerializeField] private CharacterData _characterData;

    public static event Action<CharacterData> onCharacterChoosed;

    public void ChooseCharacterOnBtnClick()
    {
        Debug.Log(_characterData.name);
        onCharacterChoosed?.Invoke(_characterData);
    }
}
