using UnityEngine;

[CreateAssetMenu(menuName = "Game/AudioSettings")]
public class AudioSettingsData : ScriptableObject
{
    [Range(0, 1)] public float masterVolume = 1;
    [Range(0, 1)] public float musicVolume = 1;
    [Range(0, 1)] public float sfxVolume = 1;

    public void SaveVolumes(float m, float mu, float s)
    {
        masterVolume = m; musicVolume = mu; sfxVolume = s;
    }
}
