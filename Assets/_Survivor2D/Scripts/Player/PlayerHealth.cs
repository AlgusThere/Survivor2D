using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] CharactersSO _CharacterSO;

    int _CurrentHealth;
    int _MaxHealth;
    int _MinHealth = 0;

    void Awake()
    {
        _MaxHealth = _CharacterSO._Health;
        _CurrentHealth = _MaxHealth;
    }

    void OnEnable() => PlayerHealthEvent.OnDamageRequestAction += DecreaseHealth;
    void OnDisable() => PlayerHealthEvent.OnDamageRequestAction -= DecreaseHealth;

    public void DecreaseHealth(int decreaseAmount)
    {
        if(_CurrentHealth <= 0) return;
        _CurrentHealth = Mathf.Max(_MinHealth, _CurrentHealth - decreaseAmount);
        PlayerHealthEvent.OnHealthChanged(_CurrentHealth);
        PlayerHealthEvent.RaiseOnHealthChangedNoV();

        if(_CurrentHealth == 0)
            PlayerHealthEvent.OnDied();

    }

}
