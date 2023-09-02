using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class RewardAd : MonoBehaviour
{
    // Подписываемся на событие открытия рекламы в OnEnable
    private void OnEnable() => YandexGame.RewardVideoEvent += Rewarded;

    // Отписываемся от события открытия рекламы в OnDisable
    private void OnDisable() => YandexGame.RewardVideoEvent -= Rewarded;

    void Rewarded(int id)
    {
        // Если ID = 1, то выдаём "+100 монет"
        if (id == 1)
            RewardApple();
    }
    public int RewardApple()
    {
        return PlayerPrefs.GetInt("Apples") + 10;
    }
    public void ExampleOpenRewardAd(int id)
    {
        // Вызываем метод открытия видео рекламы
        YandexGame.RewVideoShow(id);
    }

}
