using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

// [RequireComponent(typeof(Rigidbody2D))] // 안써도 상관없지만 써주면 이 스크립트를 넣을때 Rigidbody2D가 자동으로 들어감
public class PlayerController : MonoBehaviour
{
    // [SerializeField] private float jumpPower;
    [SerializeField] private float jumpSpeed;
    [SerializeField] private float roteto;
    private Rigidbody2D rigidbody2d;

    public UnityEvent OnJumpd;
    public UnityEvent Ondied;
    public UnityEvent OnScored;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>(); // 내 Component에 있는 Rigidbody2D 가져오기
    }

    private void Jump()
    {
        // rigidbody2d.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        rigidbody2d.velocity = Vector2.up * jumpSpeed; // velocity설정을 해주면 무조건 세팅한만큼 세팅해준다
        // rigidbody2d.velocity = Vector2.up * jumpSpeed;    // 위로 jumpSpeed만큼 간다.
        // rigidbody2d.velocity = Vector2.down * jumpSpeed;  // 밑으로 jumpSpeed만큼 간다.
        // rigidbody2d.velocity = Vector2.right * jumpSpeed; // 앞으로 jumpSpeed만큼 간다.
        // rigidbody2d.velocity = Vector2.left * jumpSpeed;  // 뒤로 jumpSpeed만큼 간다.
        // 2D게임에선 Vector3가 아닌 Vector2를 써준다.
        // rigidbody2d.AddForce는 가속도에 힘을 더해주는 방식이라 아래로 떨어질때는 어느방향으로 힘주냐에 따라 더 빨라지거나 가속도를 늦출수 있다
        // rigidbody2d.velocity는 가속도 상관없이 힘을 주는 방향으로 바로간다. 속도상관없이 바로 감
        OnJumpd?.Invoke();
        // 점프를 했을 때 실행

    }

    private void OnJump(InputValue value)
    {
        Jump();
    }

    private void Roteto()
    {
        transform.right = rigidbody2d.velocity + Vector2.right * roteto;
    }
    private void Update()
    {
        Roteto();
    }
    // Player가 부딪혔을 때
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ondied?.Invoke();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Data.CurScore++;
        OnScored?.Invoke();
    }
    // 플레이어가 트리거에 부딪히면 스코어를 얻음
}
