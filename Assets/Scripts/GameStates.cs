using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStates : MonoBehaviour
{
    private CurrentGameStates _currentGameState;

    public static GameStates Instance { get; private set; }

    private void Start()
    {
        _currentGameState = CurrentGameStates.GameEnd;
    }

    public void SetState(CurrentGameStates gameState)
    {
        _currentGameState = gameState;
        Debug.Log(_currentGameState);
        if (gameState == CurrentGameStates.GameEnd)
        {
            Time.timeScale = 0f;
        }
        if (gameState == CurrentGameStates.GameGo)
        {
            Time.timeScale = 1f;
        }
    }

    public CurrentGameStates GetState()
    {
        return _currentGameState;
    }
}

[System.Serializable]
public enum CurrentGameStates
{ 
    GameEnd,
    GameGo
}
