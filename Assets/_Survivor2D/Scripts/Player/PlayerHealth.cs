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

    void OnEnable() => PlayerHealthEvent.OnDamagedAction += DecreaseHealth;
    void OnDisable() => PlayerHealthEvent.OnDamagedAction -= DecreaseHealth;

    public void DecreaseHealth(int decreaseAmount)
    {
        _CurrentHealth -= decreaseAmount;
        _CurrentHealth = Mathf.Max(_CurrentHealth, _MinHealth);
        PlayerHealthEvent.OnHealthUIChanged(_CurrentHealth);
    }

}
