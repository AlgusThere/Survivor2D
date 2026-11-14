using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] Animator _Animator;
    [SerializeField] SpriteRenderer _SpriteRenderer;
    IMoveInput _MoveSource;

    static readonly int _WalkHash = Animator.StringToHash("_Walk");

    void Awake()
    {
        _MoveSource = GetComponent<IMoveInput>();
    }

    void Update()
    {
        Vector2 _Input = _MoveSource._Pos;

        _Animator.SetBool(_WalkHash, _Input.sqrMagnitude > 0.01f);
        
        if(Mathf.Abs(_Input.x) > 0.01f)
            _SpriteRenderer.flipX = _Input.x < 0f;
    }

}
