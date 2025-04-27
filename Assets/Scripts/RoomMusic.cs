using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(Collider))]
public class RoomMusic : MonoBehaviour
{
    public AudioClip roomClip;
    private AudioSource source;
    private static AudioSource globalMusicSource;

    void Start()
    {
        if (globalMusicSource == null)
        {
            globalMusicSource = new GameObject("MusicSource")
                .AddComponent<AudioSource>();
            globalMusicSource.loop = true;
            globalMusicSource.outputAudioMixerGroup =
                AudioManager.Instance.musicGroup;
            DontDestroyOnLoad(globalMusicSource.gameObject);
        }
        source = globalMusicSource;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            source.clip = roomClip;
            source.Play();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            source.Stop();
    }
}
