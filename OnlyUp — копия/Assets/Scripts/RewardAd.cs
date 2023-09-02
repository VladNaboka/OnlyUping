using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class RewardAd : MonoBehaviour
{
    // ������������� �� ������� �������� ������� � OnEnable
    private void OnEnable() => YandexGame.RewardVideoEvent += Rewarded;

    // ������������ �� ������� �������� ������� � OnDisable
    private void OnDisable() => YandexGame.RewardVideoEvent -= Rewarded;

    void Rewarded(int id)
    {
        // ���� ID = 1, �� ����� "+100 �����"
        if (id == 1)
            RewardApple();
    }
    public int RewardApple()
    {
        return PlayerPrefs.GetInt("Apples") + 10;
    }
    public void ExampleOpenRewardAd(int id)
    {
        // �������� ����� �������� ����� �������
        YandexGame.RewVideoShow(id);
    }

}
