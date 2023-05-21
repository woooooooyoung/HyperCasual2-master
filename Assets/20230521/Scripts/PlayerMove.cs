using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    // [SerializeField] private float rightMoveSpeed;
    private Rigidbody2D rigidbody2d;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }
    public void LeftMove()
    {
        rigidbody2d.velocity = Vector2.left * moveSpeed;
    }
    public void RightMove()
    {
        rigidbody2d.velocity = Vector2.right * moveSpeed;
    }
    public void StopMove()
    {
        rigidbody2d.velocity = Vector2.zero;
    }
}
