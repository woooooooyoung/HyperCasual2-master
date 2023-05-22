using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameSetting : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]

    private static void Init()
    {
        InitGameManager();
    }

    private static void InitGameManager()
    {
        if (GameManager.Instance == null)
        {
            GameManager gameManager = new GameManager() { name = GameManager.DefaultName };
            gameManager.AddComponent<GameManager>();
        }
    }
}
