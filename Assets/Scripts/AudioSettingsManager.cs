using UnityEngine;
public class AudioSettingsManager : MonoBehaviour
{
    public AudioSettingsData settingsData;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        ApplySettings();
    }

    public void ApplySettings()
    {
    }
}
