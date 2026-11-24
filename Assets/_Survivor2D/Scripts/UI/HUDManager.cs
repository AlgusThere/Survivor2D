using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    [SerializeField] Slider _HealthSlider;
    [SerializeField] TextMeshProUGUI _ScoreText;

    void OnEnable()
    {
        PlayerHealthEvent.OnHealthChangedAction += DecreaseHealthSlider;
        UpdateScoreEvent._UpdateScoreTextAction += UpdateScoreTextMetod;
    }
    void OnDisable()
    {
        PlayerHealthEvent.OnHealthChangedAction -= DecreaseHealthSlider;
        UpdateScoreEvent._UpdateScoreTextAction -= UpdateScoreTextMetod;
    }

    void DecreaseHealthSlider(int amount)
    {
        _HealthSlider.value = amount;
    }

    void UpdateScoreTextMetod(float amount)
    {
        _ScoreText.text = amount.ToString();
    }
}
