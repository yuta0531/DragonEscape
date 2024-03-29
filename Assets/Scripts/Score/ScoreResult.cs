using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreResult : MonoBehaviour
{
    private Text ScoreText;

    void Start()
    {
        ScoreText = GetComponentInChildren<Text>();
        //スコアをScorePresenterから持ってくる
        ScoreText.text = Mathf.Floor(ScorePresenter.instance.ScoreResultValue()).ToString();
    }
}