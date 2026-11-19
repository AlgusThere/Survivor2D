using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] EnemiesSO _EnemiesSO;

    Transform _PlayerPos;
    // Vector3 _Target;

    public void SetTarget(Transform _Pos)
    {
        _PlayerPos = _Pos;
    }

    void Update()
    {
        Movement();
        DeactiveEnemy();
    }

    void Movement()
    {
        if (_PlayerPos == null) return;
        //  _Target = _PlayerPos.position - transform.position;
        transform.position = Vector2.MoveTowards(transform.position, _PlayerPos.position, _EnemiesSO._Speed * Time.deltaTime);
        //  ALTERNATİFLER 
        //  transform.Translate(_Target * _CharactersSO._Speed * Time.deltaTime);
        //  transform.position += _Target * _CharactersSO._Speed * Time.deltaTime;
    }
    private void DeactiveEnemy()
    {
        if (Vector2.Distance(_PlayerPos.position, transform.position) < 0.01f)
        {
            gameObject.SetActive(false);
            PlayerHealthEvent.OnDamaged((int)_EnemiesSO._DamageAmount);
        }
    }

}
