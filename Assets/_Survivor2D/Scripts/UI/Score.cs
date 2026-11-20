using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    float _MinScore = 0f;
    float _CurrentScore;

    void OnEnable() => UpdateScoreEvent._UpdateScoreAction += UpdateScoreMetod;
    void OnDisable() => UpdateScoreEvent._UpdateScoreAction -= UpdateScoreMetod;

    void Start()
    {
        _CurrentScore = _MinScore;
    }

    void UpdateScoreMetod(float amount)
    {
        // Debug.Log("Gelen deger: " + amount);
        _CurrentScore += amount;
        // Debug.Log("Anlık skor: " + _CurrentScore);
        UpdateScoreEvent.UpdateScoreText(_CurrentScore);
    }


}
