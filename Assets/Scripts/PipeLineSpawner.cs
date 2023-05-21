using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeLineSpawner : MonoBehaviour
{
    [SerializeField] private float spawnDelay;
    [SerializeField] private PipeLine pipeLineprefab;

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
            Instantiate(pipeLineprefab, transform.position, transform.rotation);
        }
    }
}
