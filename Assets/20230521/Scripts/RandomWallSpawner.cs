using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWallSpawner : MonoBehaviour
{
    [SerializeField] private float spawnDelay;
    [SerializeField] private DestoryWall wallprefab;
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
            Vector2 spawnpos = transform.position + Vector3.right * Random.Range(-randomRange, randomRange);
            Instantiate(wallprefab, spawnpos, transform.rotation);
        }
    }
}
