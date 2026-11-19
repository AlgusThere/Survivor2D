using Unity.Mathematics;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject _Loot;
    Transform _LootParent;

    void Awake()
    {
        _LootParent = GameObject.FindWithTag("LootPool").transform;
    }

    public void SpawnLoot()
    {
        Instantiate(_Loot, transform.position, Quaternion.identity, _LootParent);
    }
}
