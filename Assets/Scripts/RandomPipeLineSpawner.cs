using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RandomPipeLineSpawner : MonoBehaviour
{
    [SerializeField] private float spawnDelay;
    [SerializeField] private PipeLine pipeLineprefab;
    [SerializeField] private float randomRange;

    private void OnEnable()
    {
        spawnRoutine = StartCoroutine(SpawnRoutine());
    }
    private void OnDisable()
    {
        StopCoroutine(spawnRoutine);
    }
    Coroutine spawnRoutine;
    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnDelay);
            Vector2 spawnpos = transform.position + Vector3.up * Random.Range(-randomRange, randomRange); // �����ִ� ��ġ�� �÷����� �� �Ʒ��������� �������� transform�� Vector3 ����� Vector3�� ���� �ڵ����� z���� ������
            Instantiate(pipeLineprefab, spawnpos, transform.rotation);
        }
    }
}
