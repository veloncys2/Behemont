using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] Text percentText;

    void Start()
    {
        if (!PlayerPrefs.HasKey("volumeSlider"))
        {
            PlayerPrefs.SetFloat("volumeSlider", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    public void changeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        percentText.text = Mathf.FloorToInt(volumeSlider.value * 100) + "%";
        Save();
    }

    void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("volumeSlider");
    }

    void Save()
    {
        PlayerPrefs.SetFloat("volumeSlider", volumeSlider.value);
    }
}
