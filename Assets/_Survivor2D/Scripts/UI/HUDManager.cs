using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    [SerializeField] Slider _HealthSlider;
    [SerializeField] TextMeshProUGUI _ScoreText;

    void OnEnable()
    {
        PlayerHealthEvent.OnHealthUIChangedAction += DecreaseHealthText;
        UpdateScoreEvent._UpdateScoreTextAction += UpdateScoreTextMetod;
    }
    void OnDisable()
    {
        PlayerHealthEvent.OnHealthUIChangedAction -= DecreaseHealthText;
        UpdateScoreEvent._UpdateScoreTextAction -= UpdateScoreTextMetod;
    }

    void DecreaseHealthText(int amount)
    {
        _HealthSlider.value = amount;
    }

    void UpdateScoreTextMetod(float amount)
    {
        _ScoreText.text = amount.ToString();
    }
}
