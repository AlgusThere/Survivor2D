using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class EnemySpawnPool : MonoBehaviour
{
    const int _ENEMY_AMOUNT = 10;
    [SerializeField] GameObject[] _Enemies;
    [SerializeField] TilemapCollider2D _TileMapCollider;
    [SerializeField] Transform _Player;
    [SerializeField] float _SpawnInterval = 2f;

    List<GameObject> _EnemiesList = new List<GameObject>();
    GameObject _Enemy;
    Vector2 _RandomPos;
    Bounds _Bounds;

    void Start()
    {
        CreatePool();
        StartCoroutine(SpawnerCoroutine());
    }

    void Update()
    {

    }

    void CreatePool()
    {
        _Bounds = _TileMapCollider.bounds;

        for (int i = 0; i < _ENEMY_AMOUNT; i++)
        {
            _RandomPos = new Vector2(Random.Range(_Bounds.min.x, _Bounds.max.x), Random.Range(_Bounds.min.y, _Bounds.max.y));
            if (_Enemies == null) return;
            _Enemy = Instantiate(_Enemies[Random.Range(0, _Enemies.Length)], _RandomPos, Quaternion.identity, transform);
            _Enemy.SetActive(false);
            _EnemiesList.Add(_Enemy);
            EnemyMovement _Movement = _Enemy.GetComponent<EnemyMovement>();
            _Movement.SetTarget(_Player);
        }
    }

    GameObject GetEnemyFromPool()
    {
        // foreach (GameObject enemy in _EnemiesList)
        // {
        //     if (!enemy.activeInHierarchy)
        //     {
        //         return enemy;
        //     }
        // }
        for (int i = 0; i < _EnemiesList.Count; i++)
        {
            GameObject enemy = _EnemiesList[Random.Range(0, _EnemiesList.Count)];
            if(!enemy.activeInHierarchy)
            {
                return enemy;
            }
        }
        return null;
    }

    IEnumerator SpawnerCoroutine()
    {
        while (true)
        {
            GameObject enemy = GetEnemyFromPool();
            if (enemy != null)
            {
                Vector2 _Pos = new Vector2(Random.Range(_Bounds.min.x, _Bounds.max.x), Random.Range(_Bounds.min.y, _Bounds.max.y));
                enemy.transform.position = _Pos;
                EnemyMovement _Movement = _Enemy.GetComponent<EnemyMovement>();
                _Movement.SetTarget(_Player);
                enemy.SetActive(true);
            }

            yield return new WaitForSeconds(_SpawnInterval);
        }
    }
}
