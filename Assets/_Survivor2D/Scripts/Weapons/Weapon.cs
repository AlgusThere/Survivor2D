using UnityEngine;

public abstract class Weapon : IWeapon
{
    protected readonly WeaponsSO _WeaponData;
    protected readonly IBulletSource _Bullets;
    private float _LastFireTime = float.NegativeInfinity;

    protected Weapon(WeaponsSO data, IBulletSource bullets)
    {
        _WeaponData = data;
        _Bullets = bullets;
    }

    public void TryFire(float _currentTime, Vector2 origin, Vector2 direction)
    {
        if (_currentTime - _LastFireTime < _WeaponData.FireRate) return;

        _LastFireTime = _currentTime;
        Shoot(origin, direction);
    }
    protected abstract void Shoot(Vector2 origin, Vector2 direction);
}

public class Pistol : Weapon
{
    public Pistol(WeaponsSO data, IBulletSource bullets) : base(data, bullets) { }
    protected override void Shoot(Vector2 origin, Vector2 direction)
    {
        _Bullets.Get().Launch(origin, direction, _WeaponData.DamageAmount, _WeaponData.BulletSpeed, _WeaponData.BulletLifeTime);
    }
}
// public class Shotgun : Weapon
// {
//     const int Pellets = 5;
//     const float Spread = 30f;

//     public Shotgun(WeaponsSO data, IBulletSource bullets) : base(data, bullets) { }

//     protected override void Shoot(Vector2 origin, Vector2 direction)
//     {
//         for (int i = 0; i < Pellets; i++)
//         {
//             float offset = Mathf.Lerp(-Spread / 2f, Spread / 2f, i / (float)(Pellets - 1));
//             Vector2 dir = Quaternion.Euler(0, 0, offset) * direction;
//             _Bullets.Get().Launch(origin, dir, _WeaponData.DamageAmount, _WeaponData.BulletSpeed, _WeaponData.BulletLifeTime);
//         }
//     }
// }