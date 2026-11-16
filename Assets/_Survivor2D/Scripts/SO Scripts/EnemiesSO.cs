using UnityEngine;

[CreateAssetMenu(fileName = "EnemiesSO", menuName = "Scriptable Objects/EnemiesSO")]
public class EnemiesSO : ScriptableObject
{
    [SerializeField] int _HEALTH;
    [SerializeField] float _SPEED;
    [SerializeField] float _DAMAGE_AMOUNT;

    public int _Health => _HEALTH;
    public float _Speed => _SPEED;
    public float _DamageAmount => _DAMAGE_AMOUNT;
}
