using UnityEngine;

public class PlayerBootstrap : MonoBehaviour
{
    [SerializeField] BulletPool _bulletPool;
    [SerializeField] EnemyCheck _enemyCheck;
    [SerializeField] WeaponsSO _weaponData;
    [SerializeField] WeaponShooter _weaponShooter;

    void Awake() => _weaponShooter.Initalize(new Pistol(_weaponData, _bulletPool), _enemyCheck);
}
