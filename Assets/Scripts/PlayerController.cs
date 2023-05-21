using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

// [RequireComponent(typeof(Rigidbody2D))] // �Ƚᵵ ��������� ���ָ� �� ��ũ��Ʈ�� ������ Rigidbody2D�� �ڵ����� ��
public class PlayerController : MonoBehaviour
{
    // [SerializeField] private float jumpPower;
    [SerializeField] private float jumpSpeed;
    [SerializeField] private float roteto;
    private Rigidbody2D rigidbody2d;

    public UnityEvent Ondied; 

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>(); // �� Component�� �ִ� Rigidbody2D ��������
    }

    private void Jump()
    {
        // rigidbody2d.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        rigidbody2d.velocity = Vector2.up * jumpSpeed; // velocity������ ���ָ� ������ �����Ѹ�ŭ �������ش�
        // rigidbody2d.velocity = Vector2.up * jumpSpeed;    // ���� jumpSpeed��ŭ ����.
        // rigidbody2d.velocity = Vector2.down * jumpSpeed;  // ������ jumpSpeed��ŭ ����.
        // rigidbody2d.velocity = Vector2.right * jumpSpeed; // ������ jumpSpeed��ŭ ����.
        // rigidbody2d.velocity = Vector2.left * jumpSpeed;  // �ڷ� jumpSpeed��ŭ ����.
        // 2D���ӿ��� Vector3�� �ƴ� Vector2�� ���ش�.
        // rigidbody2d.AddForce�� ���ӵ��� ���� �����ִ� ����̶� �Ʒ��� ���������� ����������� ���ֳĿ� ���� �� �������ų� ���ӵ��� ����� �ִ�
        // rigidbody2d.velocity�� ���ӵ� ������� ���� �ִ� �������� �ٷΰ���. �ӵ�������� �ٷ� ��

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
    // Player�� �ε����� ��
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ondied?.Invoke();

    }
}
