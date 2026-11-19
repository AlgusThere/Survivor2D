// using System;
// using UnityEngine;

// public class HealthModel : MonoBehaviour
// {
//     [SerializeField] CharactersSO _CharacterSO;

//     public event Action OnHealthChanged;

//     int _CurrentHealth;
//     int _minHealth = 0;
//     int _maxHealth = 100;

//     public int CurrentHealth {get => _CurrentHealth; set => _CurrentHealth = value;}
//     public int _MaxHealth => _maxHealth;
//     public int _MinHealth => _minHealth;
    

//     public void IncreaseHealth(int increaseHealth)
//     {
//         _CurrentHealth += increaseHealth;
//         _CurrentHealth = Mathf.Max(_CurrentHealth, _minHealth);
//         OnHealthChanged?.Invoke();
//     }
//     public void DecreaseHealth(int decreaseHealth)
//     {
//         _CurrentHealth -= decreaseHealth;
//         _CurrentHealth = Mathf.Min(_CurrentHealth, _maxHealth);
//         OnHealthChanged?.Invoke();
//     }

// }
