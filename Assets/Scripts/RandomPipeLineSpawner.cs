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
            Vector2 spawnpos = transform.position + Vector3.up * Random.Range(-randomRange, randomRange); // 지금있는 위치에 플러스로 위 아래방향으로 랜덤생성 transform은 Vector3 써야함 Vector3를 쓰면 자동으로 z값은 버려짐
            Instantiate(pipeLineprefab, spawnpos, transform.rotation);
        }
    }
}
