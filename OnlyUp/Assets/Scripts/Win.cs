using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] private GameObject winParticles;
    private void OnTriggerEnter(Collider other)
    {
        winParticles.SetActive(true);
        StartCoroutine(winQuit());
    }
    IEnumerator winQuit()
    {
        yield return new WaitForSeconds(5f);
        Application.Quit();
    }
}
