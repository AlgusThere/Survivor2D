using System;
using UnityEngine;
using UnityEngine.Pool;
public class BulletPool : MonoBehaviour, IBulletSource
{
    [SerializeField] Bullet _BulletPrefab;
    ObjectPool<Bullet> _Bullets;

    void Awake()
    {
        _Bullets = new ObjectPool<Bullet>(
            CreateBullet,
            OnGetFromPool,
            OnReleaseToPool,
            OnDestroyPoolObject,
            true,
            10,
            30
        );
    }

    public Bullet Get() => _Bullets.Get();

    Bullet CreateBullet()
    {
        Bullet _Bullet = Instantiate(_BulletPrefab, transform);
        _Bullet.Initialize(_Bullets);
        return _Bullet;
    }

    private void OnGetFromPool(Bullet _bullet)
    {
        _bullet.gameObject.SetActive(true);
        _bullet.OnTakenFromPool();
    }

    private void OnReleaseToPool(Bullet _bullet)
    {
        _bullet.gameObject.SetActive(false);
    }

    private void OnDestroyPoolObject(Bullet _bullet)
    {
        Destroy(_bullet.gameObject);
    }
}
