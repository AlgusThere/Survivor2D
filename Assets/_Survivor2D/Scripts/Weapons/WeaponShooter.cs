using UnityEngine;

public class WeaponShooter : MonoBehaviour
{
    [SerializeField] Transform _firePoint;

    IWeapon _IWeapon;
    ITargetProvider _Targets;

    public void Initalize(IWeapon weapon, ITargetProvider targets)
    {
        _IWeapon = weapon;
        _Targets = targets;
    }

    public void Equip(IWeapon weapon) => _IWeapon = weapon;

    void Update()
    {
        if(_IWeapon == null || _Targets.CurrentTarget == null) return;
        _IWeapon.TryFire(Time.time, _firePoint.position, _firePoint.right);
    }
}
