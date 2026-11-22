using UnityEngine;

[CreateAssetMenu(fileName = "WeaponsSO", menuName = "Scriptable Objects/WeaponsSO")]
public class WeaponsSO : ScriptableObject
{
    [Header("Weapon Settings")]
    [field: SerializeField] public float DamageAmount {get; private set;} = 10f;
    [field: SerializeField] public float FireRate {get; private set;} = 2f;
    [field: SerializeField] public float BulletSpeed {get; private set;} = 12f;
    [field: SerializeField] public float BulletLifeTime {get; private set;} = 2f;
}
