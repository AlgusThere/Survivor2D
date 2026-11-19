using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    [SerializeField] Slider _HealthSlider;

    void OnEnable() => PlayerHealthEvent.OnHealthUIChangedAction += DecreaseHealthText;
    void OnDisable() => PlayerHealthEvent.OnHealthUIChangedAction -= DecreaseHealthText;

    void DecreaseHealthText(int amount)
    {
        _HealthSlider.value = amount;
    }
}
