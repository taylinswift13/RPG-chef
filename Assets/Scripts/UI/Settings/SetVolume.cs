using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    public AudioMixer MusicMixer;
    public AudioMixer EffectsMixer;

    public Slider MusicSlider;
    public Slider EffectsSlider;

    private void Start()
    {
        MusicSlider.value = PlayerPrefs.GetFloat("MusicVolume", 0.75f);
        EffectsSlider.value = PlayerPrefs.GetFloat("EffectsVolume", 0.75f);
    }

    public void SetMusicLevel(float sliderValue)
    {
        MusicMixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("MusicVolume", sliderValue);
    }

    public void SetEffectsLevel(float sliderValue)
    {
        EffectsMixer.SetFloat("EffectsVol", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("EffectsVolume", sliderValue);
    }
}
