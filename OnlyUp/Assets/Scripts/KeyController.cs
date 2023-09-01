using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class KeyController : MonoBehaviour
{
    [SerializeField] private GameObject particleWin;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioSource audioSourceWin;
    [SerializeField] private AudioClip pickupSound;

    private void Start()
    {
        transform.DOMoveY(transform.position.y + 0.5f, 2)
            .SetEase(Ease.InOutQuad)
            .SetLoops(-1, LoopType.Yoyo);
    }
    private void OnTriggerEnter(Collider other)
    {

        if (audioSource)
        {
            //audioSource.Play();
            audioSourceWin.Play();
            AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            Debug.Log("Play Apple");
        }
        else
        {
            Debug.Log("Not audioSource");
        }

        Instantiate(particleWin, transform.position, Quaternion.identity);
        PlayerPrefs.SetInt("keyTake", 1);
        Destroy(gameObject);
    }
}
