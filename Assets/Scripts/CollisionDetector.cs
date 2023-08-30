using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public Stacker _stacker;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Collectable")
        {
            collision.gameObject.tag = "Uncollectable";
            _stacker.StackCubeUnderParent(collision);
        }
        if (collision.gameObject.tag == "Obstacle")
        {
            Destroy(gameObject.GetComponent<PlayerMovement>());
        }
    }
}
