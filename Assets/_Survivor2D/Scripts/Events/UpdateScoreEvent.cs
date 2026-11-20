using System;
using UnityEngine;

public static class UpdateScoreEvent
{
    public static event Action<float> _UpdateScoreAction;
    public static void UpateScore(float amount) => _UpdateScoreAction?.Invoke(amount);
}
