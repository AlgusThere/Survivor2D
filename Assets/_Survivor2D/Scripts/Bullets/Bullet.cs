using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Pool;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    private IObjectPool<Bullet> _pool;
    Rigidbody2D _RB;
    float _damage;
    float _releaseTime;
    bool _isInPool;

    void Awake() => _RB = GetComponent<Rigidbody2D>();
    void Update()
    {
        if(Time.time >= _releaseTime) ReleaseToPool();
    }

    public void Initialize(IObjectPool<Bullet> pool) => _pool = pool;
    public void OnTakenFromPool()
    {
        _isInPool = false;

        transform.localScale = Vector2.one;
    }

    public void Launch(Vector2 position, Vector2 direction, float damage, float speed, float lifetime)
    {
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.SetPositionAndRotation(position,Quaternion.Euler(0,0,angle));

        _damage = damage;
        _releaseTime = Time.time + lifetime;
        _RB.linearVelocity = direction * speed;
    }

    public void ReleaseToPool()
    {
        if(_isInPool || _pool == null) return;
        _isInPool = true;
        _RB.linearVelocity = Vector2.zero;
        _pool.Release(this);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(!collision.CompareTag("Enemy")) return;
        if(collision.TryGetComponent(out IDamageable target))
            target.TakeDamage(_damage);

        ReleaseToPool();
    }
}
