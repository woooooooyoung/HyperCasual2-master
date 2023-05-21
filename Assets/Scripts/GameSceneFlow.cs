using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameSceneFlow : MonoBehaviour
{
    [SerializeField] private State curState;

    public UnityEvent OnReadyed;         // ���������� ���� // ������ ó�����۵ǰ� �غ� �Ϸ���� �� ȣ��
    public UnityEvent OnPlayed;            // ���������� ���� // ������ ���۵��� ��
    public UnityEvent OnGameOver;        // ���������� ���� // ������ ������� ��

    private void Start()
    {
        Ready();
    }

    public void Ready()
    {
        curState = State.Ready;
        OnReadyed?.Invoke();
    }
    public void Play()
    {
        curState = State.Play;
        OnPlayed?.Invoke();
    }
    public void GameOver()
    {
        curState = State.GameOver;
        OnGameOver?.Invoke();
    }

    public enum State
    {
        Ready,          // �غ� �� ��Ȳ 
        Play,           // ���� �� ��Ȳ
        GameOver,       // ���� ���� ��Ȳ
    }




}
