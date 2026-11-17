using UnityEngine;

public class HealthModel : MonoBehaviour
{
    [SerializeField] CharactersSO _CharacterSO;

    public float _PlayerHealth {get; private set;}

    void Awake()
    {
        if (_CharacterSO != null)
            _PlayerHealth = _CharacterSO._Health;
    }

    public void TakeDamage(float _DamageAmount)
    {
        _PlayerHealth -= _DamageAmount;
    }

    public void Healed(float _IncraseHealthAmount)
    {
        _PlayerHealth += _IncraseHealthAmount;
    }
}
