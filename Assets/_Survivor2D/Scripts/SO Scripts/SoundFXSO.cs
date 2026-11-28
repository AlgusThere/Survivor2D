using UnityEngine;

[CreateAssetMenu(fileName = "SoundFXSO", menuName = "Scriptable Objects/SoundFXSO")]
public class SoundFXSO : ScriptableObject
{
    [field: SerializeField] public AudioClip[] _AudioClips { get; private set; }
}
