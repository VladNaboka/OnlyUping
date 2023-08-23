using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlatformMoving : MonoBehaviour
{
    [SerializeField] private Vector3 posMove;
    [SerializeField] private GameObject player;
    private void Start()
    {
        gameObject.transform.DOLocalMove(posMove, 5)
            .SetLoops(-1, LoopType.Yoyo);
    }
    private void OnTriggerEnter(Collider other)
    {
        other.transform.SetParent(transform);
        player = other.gameObject;
    }
    private void OnTriggerExit(Collider other)
    {
        other.transform.SetParent(null);
        player = null;
    }
}
