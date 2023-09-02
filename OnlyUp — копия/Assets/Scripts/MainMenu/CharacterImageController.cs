using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterImageController : MonoBehaviour
{
    [SerializeField] private Image _characterImage;

    private void OnEnable() 
    {
        CharacterChooseController.onCharacterChoosed += SetCharacterImage;
    }

    private void OnDisable() 
    {
        CharacterChooseController.onCharacterChoosed -= SetCharacterImage;
    }

    private void SetCharacterImage(CharacterData characterData)
    {
        _characterImage.sprite = characterData._characterSprite;
    }
}
