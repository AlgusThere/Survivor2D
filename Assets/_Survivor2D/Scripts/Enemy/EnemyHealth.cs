using UnityEngine;

public class EnemyHealth : MonoBehaviour, IDamageable
{
    [SerializeField] EnemiesSO _EnemiesSO;

    float _MaxHealth;
    float _MinHealth = 0f;
    float _CurrentHealth;

    void OnEnable()
    {
         _MaxHealth = _EnemiesSO._Health;
         _CurrentHealth = _MaxHealth;
    }

    public void TakeDamage(float amount)
    {
        _CurrentHealth -= amount;
        _CurrentHealth = Mathf.Max(_CurrentHealth, _MinHealth);
        if(_CurrentHealth == _MinHealth) gameObject.SetActive(false);
    }
}
