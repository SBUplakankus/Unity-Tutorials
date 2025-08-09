using UnityEngine;

public class AudioController : MonoBehaviour
{
    private AudioSource _audioSource;
    public static AudioController Instance;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        Instance = this;
    }
    
    public void PlayAudioClip(AudioClip audioClip, float volume, float pitch)
    {
        _audioSource.volume = volume;
        _audioSource.pitch = pitch;
        _audioSource.PlayOneShot(audioClip);
    }
}
