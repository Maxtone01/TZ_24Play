using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    public Rigidbody _rigidBody;
    GameStates _gameState;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _gameState = GameObject.Find("GameMediator").GetComponent<GameStates>();
    }
    public void Update()
    {
        if (_gameState.GetState() == CurrentGameStates.GameGo)
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Moved)
                {
                    transform.position = new Vector3(
                        transform.position.x,
                        transform.position.y,
                        transform.position.z + touch.deltaPosition.x * 0.003f);
                }
            }
            _rigidBody.transform.Translate(-transform.forward * 2f * Time.deltaTime, Space.World);
        }
    }
}
