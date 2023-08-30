using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEndChecker : MonoBehaviour
{
    public event EventHandler onEnableGameOverPanel;
    [SerializeField]
    GameStates _gameStates;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "GameOverObject")
        {
            onEnableGameOverPanel?.Invoke(this, EventArgs.Empty);
            _gameStates.SetState(CurrentGameStates.GameEnd);
        }
    }
}
