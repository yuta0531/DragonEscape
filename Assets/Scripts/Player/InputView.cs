using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputView : MonoBehaviour
{
    // 水平方向の入力
    public float GetMovementInput()
    {
        return Input.GetAxis("Horizontal");
    }
}
