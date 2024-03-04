using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameGroundView : MonoBehaviour
{
    [SerializeField]
    private RawImage _backImage;

    [SerializeField]
    private InGameStatus _status;

    private void Update()
    {
        BackAnimation(_status.isAlreadyHit);
    }

    //背景をループでスクロール
    private void BackAnimation(bool isAlreadyHit)
    {
        if(isAlreadyHit)
        {
            return;
        }
        var uv_rect = _backImage.uvRect;
        uv_rect.y = Mathf.Repeat(Time.time * InGameConst.BackSpeed, 1.0f);
        _backImage.uvRect = uv_rect;
    }
}