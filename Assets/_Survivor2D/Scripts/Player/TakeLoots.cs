using System.Collections.Generic;
using UnityEngine;

public class TakeLoots : MonoBehaviour
{
    [SerializeField] float _LootDistance = 1f;
    [SerializeField] float _PullStrength = 10f;
    // [SerializeField] LayerMask _LootLayer;

    List<Collider2D> _Loots = new List<Collider2D>();
    ContactFilter2D _Filter;
    // Collider2D[] _Loots;

    void Awake()
    {
        _Filter = new ContactFilter2D();
        _Filter.SetLayerMask(1 << 6);
    }

    void Update()
    {
        // _Loots = Physics2D.OverlapCircleAll(transform.position,_LootDistance,_LootLayer);
        Physics2D.OverlapCircle(transform.position, _LootDistance, _Filter, _Loots);

        foreach (Collider2D loot in _Loots)
        {
            if(loot == null) continue;
            ILootable _ILootable = loot.GetComponent<ILootable>();
            if(_ILootable == null) continue;
            Vector2 _Direction = transform.position - loot.transform.position;
            loot.transform.position += (Vector3)_Direction * _PullStrength * Time.deltaTime;
            // -----------------------------ANLIK HIZ İÇİN-----------------------------
            // loot.transform.position = Vector2.MoveTowards(loot.transform.position, transform.position, _PullStrength * Time.deltaTime);
            if(Vector2.Distance(loot.transform.position, transform.position) < 0.1f)
            {
                UpdateScoreEvent.UpdateScore(_ILootable.ReturnValue());
                // Debug.Log("Döndürülen deger: " + _ILootable.ReturnValue());
                Destroy(loot.gameObject);
            }
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, _LootDistance);
    }
}
