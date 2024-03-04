using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyView : MonoBehaviour
{
    // Image
    [SerializeField]
    private Image _EnemyImage;

    // 切り替えるスプライトの配列
    [SerializeField]
    private Sprite[] _EnemySprites;

    // スプライトのIndex
    private int _spriteIndex;

    // スプライト変更のタイマー
    private float _spriteChangeTimer;

    private Rigidbody2D _EnemyRigidbody;

    public void Initialize()
    {
        // 表示の初期化
        Reset();
        _EnemyRigidbody = GetComponent<Rigidbody2D>();
        _EnemyRigidbody.velocity = new Vector2(0, InGameConst.EnemyMoveSpeed);
    }

    /// リセット
    public void Reset()
    {
        _spriteIndex = 0;
        _spriteChangeTimer = 0f;
    }

    // 手動Update
    public void ManualUpdate(bool isAlreadyHit)
    {
        // プレイヤーの表示を更新
        EnemyUpdateView(isAlreadyHit);
        StopEnemy(isAlreadyHit);
    }

    // 走行時のアニメーションメソッド
    private void EnemyUpdateView(bool isAlreadyHit)
    {
        if (isAlreadyHit)
        {
            return;
        }

        _spriteChangeTimer -= Time.deltaTime;
        if (_spriteChangeTimer < 0f)
        {
            _spriteChangeTimer += InGameConst.SpriteChangeIntervalTime;
            _spriteIndex = (int)Mathf.Repeat(_spriteIndex + 1, _EnemySprites.Length);
            _EnemyImage.sprite = _EnemySprites[_spriteIndex];
        }
    }

    private void StopEnemy(bool isAlreadyHit)
    {
        if (!isAlreadyHit)
        {
            return;
        }

        _EnemyRigidbody.velocity = new Vector2(0, 0);
    }
}
