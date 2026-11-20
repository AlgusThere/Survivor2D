using UnityEngine;

public class FirstLoot : MonoBehaviour
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

    void OnDisable()
    {
        UpdateScoreEvent.UpateScore(_LootsSO._LootValue);
    }


}
