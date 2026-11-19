using UnityEngine;

public class FirstLoot : MonoBehaviour, ILootable
{
    SpriteRenderer _SpriteRenderer;

    public void LootAble(int amount)
    {
        
    }

    void Start()
    {
        _SpriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }
    void Update()
    {
        _SpriteRenderer.color = Color.Lerp(Color.blueViolet, Color.blue, Mathf.PingPong(Time.time, 1f));
    }


}
