using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Apple : MonoBehaviour
{
    [SerializeField] private GameObject particleObject;

    private void Start()
    {
        transform.DOMoveY(transform.position.y + 0.5f, 2)
            .SetEase(Ease.InOutQuad)
            .SetLoops(-1, LoopType.Yoyo);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Instantiate(particleObject, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
