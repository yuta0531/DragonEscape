using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreModel
{
    public float ScoreValue { get; private set; }

    public void ScoreCount(bool isAlreadyHit)
    {
        if (isAlreadyHit)
        {
            return;
        }
        //���Ԃ����ƃX�R�AUP
        ScoreValue += Time.deltaTime;
    }

    public void ScoreReset()
    {
        ScoreValue = 0;
    }
}
