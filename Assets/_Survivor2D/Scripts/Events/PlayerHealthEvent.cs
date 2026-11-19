using System;
using UnityEngine;

public static class PlayerHealthEvent
{
    public static event Action<int> OnDamagedAction;
    public static void OnDamaged(int amount) => OnDamagedAction?.Invoke(amount);
    
    public static event Action<int> OnHealthUIChangedAction;
    public static void OnHealthUIChanged(int amount) => OnHealthUIChangedAction?.Invoke(amount);
}
