using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{

    [SerializeField] float _Speed = 2f;
    InputAction _MoveAction;

    Vector2 _Pos;
    float _xPos, _yPos;

    void Start()
    {
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
