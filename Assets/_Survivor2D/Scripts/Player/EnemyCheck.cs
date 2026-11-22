using System;
using UnityEngine;

public class EnemyCheck : MonoBehaviour, ITargetProvider
{
    [Header("Target Settings")]
    [SerializeField] LayerMask _LayerMask;
    [SerializeField] float _Radius = 4f;

    [SerializeField] Transform _Weapon;
    [SerializeField] float _WeaponDistance = 1.5f;

    Collider2D[] _EnemyCollider;
    public Transform CurrentTarget {get; private set;}

    void Update()
    {
        FindClosestEnemy();
        PositionWeapon();
    }

    void FindClosestEnemy()
    {
        _EnemyCollider = Physics2D.OverlapCircleAll(transform.position, _Radius, _LayerMask);

        if (_EnemyCollider == null) return;

        CurrentTarget = null;

        float _ClosestEnemy = Mathf.Infinity;

        foreach (Collider2D _Enemy in _EnemyCollider)
        {
            float _Distance = ((Vector2)transform.position - (Vector2)_Enemy.transform.position).sqrMagnitude;
            if (_Distance < _ClosestEnemy)
            {
                _ClosestEnemy = _Distance;
                CurrentTarget = _Enemy.transform;
            }
        }
        /* for (int i = 0; i < _EnemyCollider.Length; i++)
         {
             Debug.Log(_EnemyCollider[i].CompareTag("Enemy") ? "Evet" : "Hayir");
         }*/
    }
    private void PositionWeapon()
    {
        if(CurrentTarget == null) {return;}

        Vector2 _Direction = CurrentTarget.position - transform.position;

        _Direction.Normalize();

        _Weapon.position = (Vector2)transform.position + (Vector2)(_Direction * _WeaponDistance);

        float _Angle = Mathf.Atan2(_Direction.y,_Direction.x) * Mathf.Rad2Deg;

        _Weapon.rotation = Quaternion.Euler(0,0,_Angle);

    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 4f);
    }
}
