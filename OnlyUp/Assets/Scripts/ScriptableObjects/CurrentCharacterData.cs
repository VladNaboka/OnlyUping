using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CurrentCharacterData", menuName = "ScriptableObjects/CurrentCharacterData")]
public class CurrentCharacterData : ScriptableObject
{
    [SerializeField] private CharacterData _currentCharacterData;

    public event Action<CharacterData> onCharacterDataChanged;

    public CharacterData GetCurrentCharacterData()
    {
        return _currentCharacterData;
    }

    public void SetCurrentCharacterData(CharacterData characterData)
    {
        _currentCharacterData = characterData;
    }

    public void DoCharacterCallback()
    {
        onCharacterDataChanged?.Invoke(_currentCharacterData);
    }
}
