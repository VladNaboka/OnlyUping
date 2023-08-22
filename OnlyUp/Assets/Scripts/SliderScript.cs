using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public Slider slider;

    private void Awake()
    {
        if (slider != null)
        {
            if (!PlayerPrefs.HasKey("Volume"))
            {
                AudioListener.volume = PlayerPrefs.GetFloat("Volume", 1f);
                slider.value = PlayerPrefs.GetFloat("Volume", 1f);
            }
            else
            {
                AudioListener.volume = PlayerPrefs.GetFloat("Volume");
                slider.value = PlayerPrefs.GetFloat("Volume");
            }

            slider.onValueChanged.AddListener(ChangeVolume);
        }
    }

    private void ChangeVolume(float volume)
    {
        AudioListener.volume = volume;

        PlayerPrefs.SetFloat("Volume", volume);
        PlayerPrefs.Save();
    }

    private void OnDestroy()
    {
        if (slider != null)
        {
            slider.onValueChanged.RemoveListener(ChangeVolume);
        }
    }
}

