using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiController : MonoBehaviour
{
    [SerializeField] GameEndChecker _gameOverChecker;
    [SerializeField] GameObject _gameOverPanel;

    private void Start()
    {
        _gameOverChecker.onEnableGameOverPanel += EnablePanel;
    }

    public void EnablePanel(object sender, EventArgs e)
    {
        _gameOverPanel.SetActive(true);
    }
}
