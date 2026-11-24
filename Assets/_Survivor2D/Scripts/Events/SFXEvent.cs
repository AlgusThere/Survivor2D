using System;
using UnityEngine;

public static class SFXEvent
{
    public static event Action<AudioClip> PlayGameOverAudioAction;
    public static void PlayGameOverAudio(AudioClip audioClip) => PlayGameOverAudioAction?.Invoke(audioClip);
}
