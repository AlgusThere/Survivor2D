using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    float _MinScore = 0f;
    float _CurrentScore;

    void OnEnable() => UpdateScoreEvent._UpdateScoreAction += UpdateScore;
    void OnDisable() => UpdateScoreEvent._UpdateScoreAction -= UpdateScore;

    void Start()
    {
        _CurrentScore = _MinScore;
    }

    void UpdateScore(float amount)
    {
        _CurrentScore = amount;
    }


}
