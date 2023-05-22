using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreView : MonoBehaviour
{
    private TMP_Text tmp_text;
    private void Awake()
    {
        tmp_text = GetComponent<TMP_Text>();
    }

    private void OnEnable()
    {
        GameManager.Data.OnBestScoreChanged += ChangeScore;
        // 데이터 매니저에 있는 커런트스코어가 바뀔떄마다 있으면 무조건 반응
    }
    private void OnDisable()
    {
        GameManager.Data.OnBestScoreChanged -= ChangeScore;
        // 반응 x
    }
    private void ChangeScore(int score)
    {
        tmp_text.text = score.ToString();
    }
}
