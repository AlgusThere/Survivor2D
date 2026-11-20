using UnityEngine;

public class FirstLoot : MonoBehaviour, ILootable
{
    [SerializeField] LootsSO _LootsSO;
    SpriteRenderer _SpriteRenderer;


    void Start()
    {
        _SpriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }
    void Update()
    {
        _SpriteRenderer.color = Color.Lerp(Color.blueViolet, Color.blue, Mathf.PingPong(Time.time, 1f));
    }
    public float ReturnValue()
    {
        float _returnValue = _LootsSO._LootValue;
        return _returnValue;
    }

    // void OnDisable()
    // {
    //     UpdateScoreEvent.UpdateScore(_LootsSO._LootValue);
    // }


}
