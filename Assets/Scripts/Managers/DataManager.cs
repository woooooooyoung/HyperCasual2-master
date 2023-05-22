using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DataManager : MonoBehaviour
{
    private int bestScore;
    public int BestScore
    {
        get { return bestScore; }
        set
        {
            if (bestScore != value)
                OnBestScoreChanged?.Invoke(value);
            bestScore = value;
        }
    }
    public event UnityAction<int> OnBestScoreChanged;

    private int curScore;
    public int CurScore
    {
        get { return curScore; }
        set
        {
                OnCurScoreChanged?.Invoke(value);
                curScore = value;
            
            if (curScore > BestScore)
                BestScore = curScore;
            // 만약에 현재점수를 세팅했는데 최고점수보다 높은경우면 베스트 스코어 자체가 현재점수가 베스트 스코어보다 높으면 현재 스코어를 베스트 스코어로 설정해줄 필요가 있다.
        }
    }
    public event UnityAction<int> OnCurScoreChanged;
}
