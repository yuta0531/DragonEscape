using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyView : MonoBehaviour
{
    // Image
    [SerializeField]
    private Image _EnemyImage;

    // �؂�ւ���X�v���C�g�̔z��
    [SerializeField]
    private Sprite[] _EnemySprites;

    // �X�v���C�g��Index
    private int _spriteIndex;

    // �X�v���C�g�ύX�̃^�C�}�[
    private float _spriteChangeTimer;

    private Rigidbody2D _EnemyRigidbody;

    public void Initialize()
    {
        // �\���̏�����
        Reset();
        _EnemyRigidbody = GetComponent<Rigidbody2D>();
        _EnemyRigidbody.velocity = new Vector2(0, InGameConst.EnemyMoveSpeed);
    }

    /// ���Z�b�g
    public void Reset()
    {
        _spriteIndex = 0;
        _spriteChangeTimer = 0f;
    }

    // �蓮Update
    public void ManualUpdate(bool isAlreadyHit)
    {
        // �v���C���[�̕\�����X�V
        EnemyUpdateView(isAlreadyHit);
        StopEnemy(isAlreadyHit);
    }

    // ���s���̃A�j���[�V�������\�b�h
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
