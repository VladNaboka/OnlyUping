using UnityEngine;
using YG;
using System.Collections;

public class Ad : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(ShowAd());
    }

    IEnumerator ShowAd()
    {
        while (true) 
        {
            yield return new WaitForSeconds(180f);
            YandexGame.FullscreenShow();
        }
    }
}
