using UnityEngine;

public class Gun : MonoBehaviour, IWeapon
{
    [SerializeField] WeaponsSO _WeaponsSO;

    Transform _FirePoint;

    public float _DamageAmount => throw new System.NotImplementedException();

    public float _FireDuration => throw new System.NotImplementedException();
}
