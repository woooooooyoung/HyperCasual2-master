using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeLine : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        // deltaTime¿∫ 
    }
}
