using System;
using UnityEngine;

public static class UpdateScoreEvent
{
    public static event Action<float> _UpdateScoreAction;
    public static void UpdateScore(float amount) => _UpdateScoreAction?.Invoke(amount); 
    public static event Action<float> _UpdateScoreTextAction;
    public static void UpdateScoreText(float amount) => _UpdateScoreTextAction?.Invoke(amount);
}
