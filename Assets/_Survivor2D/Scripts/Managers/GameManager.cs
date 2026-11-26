using UnityEditor;
using UnityEngine;

public enum GameState
{
    Playing,
    Paused,
    GameOver,
    Victory
}

public class GameManager : MonoBehaviour
{
    public GameState CurrentState {get; private set;}
    float _CurrentTimeScale = 1f;

    void Awake()
    {
        Time.timeScale = _CurrentTimeScale;
    }

    void OnEnable()
    {
        GameManagerEvent.GameStateRequestedAction += ChangeGameState;
    }
    void OnDisable()
    {
        GameManagerEvent.GameStateRequestedAction -= ChangeGameState;
        
    }

    private void ChangeGameState(GameState newState)
    {
        if(CurrentState == newState) return;
        CurrentState = newState;
        Time.timeScale = CurrentState == GameState.Paused ? 1f : 0f;
    }
}
