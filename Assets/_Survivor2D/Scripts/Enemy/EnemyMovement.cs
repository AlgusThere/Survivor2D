using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] Transform _PlayerPos;
    [SerializeField] CharactersSO _CharactersSO;

    Vector3 _Target;
    
    void Update()
    {
       _Target = _PlayerPos.position - transform.position;

       transform.Translate(_Target * _CharactersSO._Speed * Time.deltaTime);
    }
}
