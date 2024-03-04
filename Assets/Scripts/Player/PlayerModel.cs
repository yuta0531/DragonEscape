using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel
{
    // Player�̂����W
    public float Pos_X {get; private set;}

    // Player�̂����W�̈ړ�
    public void Move(float input, bool isAlreadyHit)
    {
        //���S���͓����Ȃ�����
        if (isAlreadyHit)
        {
            return;
        }

        float moveX = input * Time.deltaTime * InGameConst.PlayerMoveSpeed;
        Pos_X = Mathf.Clamp(Pos_X + moveX, -350.0f, 350.0f);
    }
}
