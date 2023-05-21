using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryPipeLine : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private void Start()
    {
        Destroy(gameObject, 6);
    }
    private void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
}
