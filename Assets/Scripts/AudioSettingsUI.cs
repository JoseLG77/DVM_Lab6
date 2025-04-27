using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioSettingsUI : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider masterSlider, musicSlider, sfxSlider;
    public AudioSettingsData settingsData;

    void Start()
    {
        masterSlider.value = settingsData.masterVolume;
        musicSlider.value = settingsData.musicVolume;
        sfxSlider.value = settingsData.sfxVolume;

        masterSlider.onValueChanged.AddListener(v => UpdateVolume("MasterVol", v));
        musicSlider.onValueChanged.AddListener(v => UpdateVolume("MusicVol", v));
        sfxSlider.onValueChanged.AddListener(v => UpdateVolume("SFXVol", v));
    }

    void UpdateVolume(string param, float value)
    {
        mixer.SetFloat(param, Mathf.Log10(value) * 20);
        settingsData.SaveVolumes(masterSlider.value, musicSlider.value, sfxSlider.value);
    }
}
