using UnityEngine;

public abstract class Weapon : IWeapon
{
    protected float _Damage;
    protected float _fireDuration;
    private float _LastFireTime;

    protected Weapon(float _damageAmount , float _durationAmount)
    {
        _Damage = _damageAmount;
        _fireDuration = _durationAmount;
    }

    public void Fire(float _currentTime)
    {
        if(_currentTime - _LastFireTime < _fireDuration) return;

        _LastFireTime = _currentTime;
        Shoot();
    }

    protected abstract void Shoot();
    public float _DamageAmount => throw new System.NotImplementedException();
    public float _FireDuration => throw new System.NotImplementedException();
}

public class Pistol : Weapon
{
    public Pistol() : base(_damageAmount: 10, _durationAmount: 2f) {}
    protected override void Shoot()
    {
        Debug.Log($"Tek mermi: {_DamageAmount} hasar");
    }
}