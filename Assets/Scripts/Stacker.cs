using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stacker : MonoBehaviour
{
    public Transform _stackPosition;
    [SerializeField]
    StackScoreShower _scoreShower;
    [SerializeField]
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void StackCubeUnderParent(Collision cube)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
        cube.transform.position = new Vector3(_stackPosition.position.x, _stackPosition.position.y, _stackPosition.position.z);
        cube.gameObject.AddComponent<PlayerMovement>();
        cube.gameObject.AddComponent<CollisionDetector>()._stacker = this;
        cube.gameObject.transform.parent = null;
        _scoreShower.OnShowText();
        animator.Play("Jumping");
    }
}
