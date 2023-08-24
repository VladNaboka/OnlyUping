using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestWin : MonoBehaviour
{
    [SerializeField] private Animator anim;
    private void OnTriggerEnter(Collider other)
    {
        if (PlayerPrefs.GetInt("keyTake") == 1)
        {
            anim.SetBool("chestAnim", true);
        }
    }
}
