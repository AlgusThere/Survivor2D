using UnityEngine;

[CreateAssetMenu(fileName = "WeaponsSO", menuName = "Scriptable Objects/WeaponsSO")]
public class WeaponsSO : ScriptableObject
{
    [SerializeField] float _damageAmount;
    [SerializeField] float _fireDuration;

    public float _DamageAmount => _damageAmount;
    public float _FireDuration => _fireDuration;
}
