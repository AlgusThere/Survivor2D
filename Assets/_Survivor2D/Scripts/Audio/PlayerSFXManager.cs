using System.Collections.Generic;
using UnityEngine;

public class PlayerSFXManager : MonoBehaviour
{
    [SerializeField] AudioSource _PlayerSFX;
    [SerializeField] CharactersSO _PlayerAudios;

    Dictionary<string, AudioClip> _AudioDic = new();

    void Awake()
    {
        foreach (AudioClip clip in _PlayerAudios.PlayerAudios)
        {
            if(clip == null) continue;
            if(!_AudioDic.ContainsKey(clip.name))
                _AudioDic.Add(clip.name, clip);
        }
    }

    void OnEnable()
    {
        PlayerHealthEvent.OnDiedAction += PlayGameOverSFX;
        PlayerHealthEvent.OnHealthChangedActionNoV += PlayDamagedSFX;

    }
    void OnDisable()
    {
        PlayerHealthEvent.OnDiedAction -= PlayGameOverSFX;
        PlayerHealthEvent.OnHealthChangedActionNoV -= PlayDamagedSFX;
        
    }
    void PlayDamagedSFX()
    {
        if(_AudioDic.TryGetValue("Damaged", out AudioClip damagedClip))
            _PlayerSFX.PlayOneShot(damagedClip);
    }

    void PlayGameOverSFX()
    {
        if (_AudioDic.TryGetValue("GameOver", out AudioClip gameOverClip))
            _PlayerSFX.PlayOneShot(gameOverClip);
    }


}
