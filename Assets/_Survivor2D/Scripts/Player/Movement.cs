using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;

public class Movement : MonoBehaviour, IMoveInput
{
    [SerializeField] CharactersSO _CharactersSO;
    [SerializeField] TilemapCollider2D _TilemapCollider;
    InputAction _MoveAction;
    public Vector2 _Pos {get; private set;}
    float _Speed;
    float _xPos, _yPos;

    Bounds _PosBounds;

    void Start()
    {
        _Speed = _CharactersSO._Speed;
        _MoveAction = InputSystem.actions.FindAction("Move");
        _PosBounds = _TilemapCollider.bounds;
    }

    void Update()
    {
        Move();
        ClampPosition();
    }
    void ClampPosition()
    {
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, _PosBounds.min.x + .3f, _PosBounds.max.x - .3f),
                                        Mathf.Clamp(transform.position.y, _PosBounds.min.y + .7f, _PosBounds.max.y + .3f));
    }

    private void Move()
    {
        _Pos = _MoveAction.ReadValue<Vector2>();

        _xPos = _Pos.x * Time.deltaTime * _Speed;
        _yPos = _Pos.y * Time.deltaTime * _Speed;

        transform.Translate(_xPos, _yPos, 0);
    }
}
