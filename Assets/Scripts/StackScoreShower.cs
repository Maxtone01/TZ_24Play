using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StackScoreShower : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI _scoreText;

    private void Start()
    {
        _scoreText.enabled = false;
    }

    public void OnShowText()
    {
        StartCoroutine(ShowText());
    }

    private IEnumerator ShowText()
    {
        _scoreText.enabled = true;
        yield return new WaitForSeconds(0.5f);
        _scoreText.enabled = false;
        StopCoroutine(ShowText());
    }
}
