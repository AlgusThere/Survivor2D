using System.Collections.Generic;
using UnityEngine;

public class UISFXManager : MonoBehaviour
{
    [SerializeField] AudioSource _UISFXSource;
    [SerializeField] SoundFXSO _SoundFXSO;

    Dictionary<string, AudioClip> _SFXDic = new();

    void Awake()
    {
        foreach (AudioClip clip in _SoundFXSO._AudioClips)
        {
            if(clip == null) continue;
            if(!_SFXDic.ContainsKey(clip.name))
                _SFXDic.Add(clip.name, clip);
        }
    }

    public void PlayClickSound()
    {
        if(_SFXDic.TryGetValue("ClickToButton", out AudioClip clickButtonClip))
            _UISFXSource.PlayOneShot(clickButtonClip);
    }
}
