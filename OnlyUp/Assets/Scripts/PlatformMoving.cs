using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlatformMoving : MonoBehaviour
{
    [SerializeField] private Vector3 posMove;
    [SerializeField] private GameObject player;
    [SerializeField] private float speedMoving = 5f;

    public enum MethodType { PlatformMove, ScaleObject }
    public MethodType selectedMethod;
    private Vector3 originalScale;
    private Vector3 targetScale;
    [SerializeField] private float scaleSize = .5f;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        originalScale = transform.localScale;
        targetScale = originalScale * scaleSize;

        if (player != null)
        {
            Debug.Log("Игрок найден");
        }
        else
        {
            Debug.Log("Игрока нет");
        }

        switch (selectedMethod)
        {
            case MethodType.PlatformMove:
                StartPlatformMove();
                break;
            case MethodType.ScaleObject:
                StartScaleObject();
                break;
            default:
                Debug.LogError("No method");
                break;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        other.transform.SetParent(null);
        player = null;
    }

    private void OnTriggerEnter(Collider other)
    {
        other.transform.SetParent(transform);
        player = other.gameObject;
        Debug.Log("PlayerTrigger");
    }

    private void StartPlatformMove()
    {
        gameObject.transform.DOLocalMove(posMove, speedMoving)
            .SetLoops(-1, LoopType.Yoyo);
    }

    private void StartScaleObject()
    {
        transform.DOScale(targetScale, speedMoving)
        .SetLoops(-1, LoopType.Yoyo);
    }

    private void ReturnToOriginalScale()
    {
        transform.DOScale(originalScale, speedMoving); // Возвращаем объект к исходному размеру
    }

    //private void Start()
    //{
    //    player = GameObject.FindGameObjectWithTag("Player");
    //    if (player != null)
    //    {
    //        Debug.Log("Found Player object from prefab.");
    //    } else
    //    {
    //        Debug.Log("Player awake");
    //    }

    //    gameObject.transform.DOLocalMove(posMove, speedMoving)
    //        .SetLoops(-1, LoopType.Yoyo);
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    other.transform.SetParent(null);
    //    player = null;
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    other.transform.SetParent(transform);
    //    player = other.gameObject;
    //    Debug.Log("PlayerTrigger");
    //}


}
