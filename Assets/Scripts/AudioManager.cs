using UnityEngine;
using UnityEngine.Audio;  

public class AudioManager : MonoBehaviour
{
    public AudioMixer masterMixer;  

    public void SetMusicVolume(float volume)
    {
        masterMixer.SetFloat("MusicVol", Mathf.Log10(volume) * 20);
    }

    public void SetSFXVolume(float volume)
    {
        masterMixer.SetFloat("SFXVol", Mathf.Log10(volume) * 20);
    }

    public void SetMasterVolume(float volume)
    {
        masterMixer.SetFloat("MasterVol", Mathf.Log10(volume) * 20);
    }
}
