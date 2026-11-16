using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] Transform _PlayerPos;
    [SerializeField] EnemiesSO _EnemiesSO;

    Vector3 _Target;
    
    void Update()
    {
       _Target = _PlayerPos.position - transform.position;

        transform.position = Vector2.MoveTowards(transform.position, _PlayerPos.position, _EnemiesSO._Speed * Time.deltaTime);
        // ALTERNATİFLER 
        //  transform.Translate(_Target * _CharactersSO._Speed * Time.deltaTime);
        //  transform.position += _Target * _CharactersSO._Speed * Time.deltaTime;

    }
}
