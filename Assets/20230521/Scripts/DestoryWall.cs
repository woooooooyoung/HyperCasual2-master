using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryWall : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private void Start()
    {
        Destroy(gameObject, 6);
    }
    private void Update()
    {
        transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
    }
}
