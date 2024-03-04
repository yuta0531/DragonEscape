using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel
{
    // Playerのｘ座標
    public float Pos_X {get; private set;}

    // Playerのｘ座標の移動
    public void Move(float input, bool isAlreadyHit)
    {
        //死亡時は動けなくする
        if (isAlreadyHit)
        {
            return;
        }

        float moveX = input * Time.deltaTime * InGameConst.PlayerMoveSpeed;
        Pos_X = Mathf.Clamp(Pos_X + moveX, -350.0f, 350.0f);
    }
}
