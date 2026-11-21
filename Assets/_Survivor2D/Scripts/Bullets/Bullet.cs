using UnityEngine;
using UnityEngine.Pool;

public class Bullet : MonoBehaviour
{
    private IObjectPool<Bullet> _pool;

    bool _isInPool;

    public void Initialize(IObjectPool<Bullet> pool)
    {
        _pool = pool;
    }
    public void OnTakenFromPool()
    {
        _isInPool = false;

        transform.localScale = Vector2.one;
    }

    public void ReturnToPool()
    {
        if(_isInPool || _pool == null)
        {
            
        }
    }
}
