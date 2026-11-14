using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour, IMoveInput
{
    [SerializeField] CharactersSO _CharactersSO;
    InputAction _MoveAction;
    public Vector2 _Pos {get; private set;}
    float _Speed;
    float _xPos, _yPos;

    void Start()
    {
        _Speed = _CharactersSO._Speed;
        _MoveAction = InputSystem.actions.FindAction("Move");
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        _Pos = _MoveAction.ReadValue<Vector2>();

        _xPos = _Pos.x * Time.deltaTime * _Speed;
        _yPos = _Pos.y * Time.deltaTime * _Speed;

        transform.Translate(_xPos, _yPos, 0);
    }
}
