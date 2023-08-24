using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Apple : MonoBehaviour
{
    [SerializeField] private GameObject particleObject;
    private PlayerStats _playerStats;

    private void Awake()
    {
        _playerStats = FindObjectOfType<PlayerStats>();
    }

    private void Start()
    {
        if (PlayerPrefs.GetInt("apple" + gameObject.name) == 0)
        {
            transform.DOMoveY(transform.position.y + 0.5f, 2)
                        .SetEase(Ease.InOutQuad)
                        .SetLoops(-1, LoopType.Yoyo);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Instantiate(particleObject, transform.position, Quaternion.identity);
        _playerStats.AddApple(1);
        PlayerPrefs.SetInt("apple" + gameObject.name, 1);
        Destroy(gameObject);
    }
}
