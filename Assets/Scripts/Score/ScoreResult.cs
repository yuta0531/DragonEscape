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
        //ƒXƒRƒA‚ğScorePresenter‚©‚ç‚Á‚Ä‚­‚é
        ScoreText.text = Mathf.Floor(ScorePresenter.instance.ScoreResultValue()).ToString();
    }
}