using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerView : MonoBehaviour
{
    // Playerの画像
    [SerializeField]
    private Image _image;

    // 走行時のアニメーション画像配列
    [SerializeField]
    private Sprite[] _sprites;

    // 死亡時のアニメーション画像配列
    [SerializeField]
    private Sprite[] _deadSprites;

    // 現在のアニメーション画像番号
    private int _spriteIndex;

    // 画像変換タイマー
    private float _spriteChangeTimer;
        
    // 現在位置
    private RectTransform rectTransform;

        
    public void Initialize()
    {
        Reset();
        rectTransform = GetComponent<RectTransform>();
    }

    // 画像の初期化
    private void Reset()
    {
        _spriteIndex = 0;
        _spriteChangeTimer = 0f;
    }

    // 走行時死亡時のアニメーション→PlayerPresenterへ
    public void ManualUpdate(bool isAlreadyHit)
    {
        UpdateView(isAlreadyHit);
        DeadView(isAlreadyHit);
    }

    // 走行時のアニメーションメソッド
    private　void UpdateView(bool isAlreadyHit)
    {
        if (isAlreadyHit)
        {
            return;
        }

        _spriteChangeTimer -= Time.deltaTime;
        if (_spriteChangeTimer < 0f)
        {
            _spriteChangeTimer += InGameConst.SpriteChangeIntervalTime;
            _spriteIndex = (int)Mathf.Repeat(_spriteIndex + 1, _sprites.Length);
            _image.sprite = _sprites[_spriteIndex];
        }
    }

    // Playerの画面上の位置変更メソッド→PlayerPresenterへ
    public void UpdatePosition(float playerPos_X, bool isAlreadyHit)
    {   
        //死亡時は動けなくする
        if (isAlreadyHit)
        {
            return;
        }

        rectTransform.anchoredPosition = new Vector2(playerPos_X, rectTransform.anchoredPosition.y);
    }

    // 敵に当たったら画像番号などをリセット→PlayerPresenterへ
    public void HitEnemy(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Reset();
        }
    }

    // 死亡時のアニメーションのメソッド
    private void DeadView(bool isAlreadyHit)
    {
        if (!isAlreadyHit)
        {
            return;
        }

        _spriteChangeTimer -= Time.deltaTime;
        if (_spriteChangeTimer < 0f)
        {
            if (_spriteIndex < _deadSprites.Length)
            {
                _spriteChangeTimer += InGameConst.SpriteChangeIntervalTime;
                _image.sprite = _deadSprites[_spriteIndex];
                _spriteIndex++;
            }   
            else
            {
                //死亡時のアニメーションが終われば、Result画面へ
                SceneManager.LoadScene("Result");
            }
        }
    }   
}
