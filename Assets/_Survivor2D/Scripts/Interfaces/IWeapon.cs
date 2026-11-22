using UnityEngine;

public interface IWeapon { void TryFire(float currentTime, Vector2 origin, Vector2 direction); }
public interface IBulletSource { Bullet Get(); }
public interface ITargetProvider { Transform CurrentTarget { get; } }
public interface IDamageable { void TakeDamage(float amount); }
