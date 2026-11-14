using UnityEngine;

[CreateAssetMenu(fileName = "CharactersSO", menuName = "Scriptable Objects/CharactersSO")]
public class CharactersSO : ScriptableObject
{
    [SerializeField] int _HEALTH;
    [SerializeField] float _SPEED;

    public int _Health => _HEALTH;
    public float _Speed => _SPEED;
}
