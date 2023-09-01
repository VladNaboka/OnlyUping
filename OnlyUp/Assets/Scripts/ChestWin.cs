using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChestWin : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (PlayerPrefs.GetInt("keyTake") == 1)
        {
            StartCoroutine(animChest());

            GameManager.instance.checkGameOver = true;
        }
    }

    IEnumerator animChest()
    {
        anim.SetBool("chestAnim", true);
        audioSource.Play();
        yield return new WaitForSeconds(1f);
        audioSource.enabled = false;
        yield return new WaitForSeconds(5f);
        
        PlayerPrefs.SetInt("Win1Level", 1);
    }

}
