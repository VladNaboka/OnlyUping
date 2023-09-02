using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "ScriptableObjects/CharacterData")]
public class CharacterData : ScriptableObject
{
    [field: SerializeField] public Sprite _characterSprite { get; private set; }
    [field: SerializeField] public GameObject _characterPrefab { get; private set; }
}
