using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameSceneFlow : MonoBehaviour
{
    [SerializeField] private State curState;

    public UnityEvent OnReadyed;         // 옵저버패턴 적용 // 게임이 처음시작되고 준비 완료됐을 때 호출
    public UnityEvent OnPlayed;            // 옵저버패턴 적용 // 게임이 시작됐을 때
    public UnityEvent OnGameOver;        // 옵저버패턴 적용 // 게임이 종료됐을 때

    private void Start()
    {
        Ready();
        GameManager.Data.CurScore = 0;
        // 시작하자마자 현재점수는 0
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
        Ready,          // 준비 중 상황 
        Play,           // 진행 중 상황
        GameOver,       // 게임 오버 상황
    }




}
