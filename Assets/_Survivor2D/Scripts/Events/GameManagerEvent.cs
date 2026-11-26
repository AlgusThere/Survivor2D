using System;
using UnityEngine;

public static class GameManagerEvent
{
    public static event Action<GameState> GameStateRequestedAction;
    public static void RaiseGameStateAction(GameState GameStateRequested) => GameStateRequestedAction?.Invoke(GameStateRequested);
}
