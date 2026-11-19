// using System;
// using TMPro;
// using UnityEngine;

// public class HealthPresenter : MonoBehaviour
// {
//     [SerializeField] HealthModel _HealthModel;
//     [SerializeField] TextMeshPro _HealthTextUI;

//     public event Action OnDamaged;
//     public event Action OnHealed;

//     void Awake()
//     {
//         _HealthModel.CurrentHealth = _HealthModel._MaxHealth;
//     }

//     void OnEnable() => _HealthModel.OnHealthChanged += Health_OnHealthChanged;
//     void OnDisable() => _HealthModel.OnHealthChanged -= Health_OnHealthChanged;

//     void Health_OnHealthChanged()
//     {
//         UpdateView();
//     }

//     private void UpdateView()
//     {
//         if(_HealthModel == null) {return;}
//         if(_HealthTextUI != null) _HealthTextUI.text = _HealthModel.CurrentHealth.ToString();
//     }

//     public void IncreaseHealth(int amount)
//     {
//         _HealthModel.IncreaseHealth(amount);
//         OnHealed?.Invoke();
//     }
//     public void DecreaseHealth(int amount)
//     {
//         _HealthModel.DecreaseHealth(amount);
//         OnDamaged?.Invoke();
//     }
// }
