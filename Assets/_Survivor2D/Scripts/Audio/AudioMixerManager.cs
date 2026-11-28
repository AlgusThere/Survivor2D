using UnityEngine;
using UnityEngine.Audio;

public class AudioMixerManager : MonoBehaviour
{
    [SerializeField] private AudioMixer _AudioMixer;

    public void SetAudioVolume(float value)
    {
        _AudioMixer.SetFloat("MusicVolume", Mathf.Log10(value) * 20f);
        
    }

    public void SetSFXVolume(float value)
    {
        _AudioMixer.SetFloat("SFXVolume", Mathf.Log10(value) * 20f);
    }
}
