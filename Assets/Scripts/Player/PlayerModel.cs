using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel
{
    // Player‚Ì‚˜À•W
    public float Pos_X {get; private set;}

    // Player‚Ì‚˜À•W‚ÌˆÚ“®
    public void Move(float input, bool isAlreadyHit)
    {
        //€–S‚Í“®‚¯‚È‚­‚·‚é
        if (isAlreadyHit)
        {
            return;
        }

        float moveX = input * Time.deltaTime * InGameConst.PlayerMoveSpeed;
        Pos_X = Mathf.Clamp(Pos_X + moveX, -350.0f, 350.0f);
    }
}
