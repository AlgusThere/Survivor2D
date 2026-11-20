using UnityEngine;

public class TakeLoots : MonoBehaviour
{
    [SerializeField] float _LootDistance = 1f;
    [SerializeField] LayerMask _LootLayer;

    Collider2D[] _Loots;

    void Update()
    {
        _Loots = Physics2D.OverlapCircleAll(transform.position,_LootDistance,_LootLayer);

        if(_Loots == null) return;

        
    }
}
