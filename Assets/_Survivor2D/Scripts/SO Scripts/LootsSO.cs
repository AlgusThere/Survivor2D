using UnityEngine;

[CreateAssetMenu(fileName = "LootsSO", menuName = "Scriptable Objects/LootsSO")]
public class LootsSO : ScriptableObject
{
    [SerializeField] float _lootValue;

    public float _LootValue => _lootValue;
}
