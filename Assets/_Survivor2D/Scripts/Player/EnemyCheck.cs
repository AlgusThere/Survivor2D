using UnityEngine;

public class EnemyCheck : MonoBehaviour
{
    [SerializeField] LayerMask _LayerMask;
    [SerializeField] float _Radius = 4f;
    Collider2D[] _EnemyCollider = new Collider2D[10];

    ContactFilter2D _CFilter;

    void Start()
    {
        _CFilter = new ContactFilter2D{useLayerMask = true, layerMask = _LayerMask, useTriggers = true};
    }

    // int _LayerMask = 1 << 7;

    void Update()
    {
        int _Count = Physics2D.OverlapCircle(transform.position, _Radius, _CFilter, _EnemyCollider);

        if(_EnemyCollider == null) return;
        
        for (int i = 0; i < _Count; i++)
        {
            Debug.Log(_EnemyCollider[i].name);
        }

        // for (int i = 0; i < _EnemyCollider.Length; i++)
        // {
        //     Debug.Log(_EnemyCollider[i].CompareTag("Enemy") ? "Evet" : "Hayir");
        // }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 4f);
    }
}
