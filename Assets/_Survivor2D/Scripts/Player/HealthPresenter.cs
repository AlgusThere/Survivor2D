using TMPro;
using UnityEngine;

public class HealthPresenter : MonoBehaviour
{
    [SerializeField] HealthModel _HealthModel;
    [SerializeField] TextMeshPro _HealthTextUI;

    void Awake()
    {
        _HealthTextUI.text = _HealthModel._PlayerHealth.ToString();
    }

    void Damaged()
    {
        
    }
    
    void IncreaseHealth()
    {
        
    }



}
