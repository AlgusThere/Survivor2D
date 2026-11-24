using System;
public static class PlayerHealthEvent
{
    public static event Action<int> OnDamageRequestAction;
    public static void OnDamaged(int amount) => OnDamageRequestAction?.Invoke(amount);
    
    public static event Action<int> OnHealthChangedAction;
    public static void OnHealthChanged(int amount) => OnHealthChangedAction?.Invoke(amount);
    public static event Action OnHealthChangedActionNoV;
    public static void RaiseOnHealthChangedNoV() => OnHealthChangedActionNoV?.Invoke();

    public static event Action OnDiedAction;
    public static void OnDied() => OnDiedAction?.Invoke();

    /*
    Enter Play Mode Options'da "Reload Domain" kapalıysa static event'ler,
    Play'ler arasında temizlenmez. Kapatmayacaksan bu metodu silebilirsin.
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
    static void ResetStatics()
    {
        HealthChanged = null;
        Died = null;
    }
    */
}
