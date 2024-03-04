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
        //ŽžŠÔ‚ª‚½‚Â‚ÆƒXƒRƒAUP
        ScoreValue += Time.deltaTime;
    }

    public void ScoreReset()
    {
        ScoreValue = 0;
    }
}
