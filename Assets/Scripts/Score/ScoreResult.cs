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
        //�X�R�A��ScorePresenter���玝���Ă���
        ScoreText.text = Mathf.Floor(ScorePresenter.instance.ScoreResultValue()).ToString();
    }
}