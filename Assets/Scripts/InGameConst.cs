using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameConst : MonoBehaviour
{
    //Player�����E�Ɉړ�����X�s�[�h
    public const float PlayerMoveSpeed = 500.0f;

    //Player��Bomb�̃A�j���[�V�����̃X�v���C�g�ύX�̎��ԊԊu
    public const float SpriteChangeIntervalTime = 0.1f;

    //Enemy���ړ�����X�s�[�h
    public const float EnemyMoveSpeed = -280f;

    //Enemy�����������C���^�[�o���b
    public const float generationInterval = 0.8f;

    //Enemy�̐��������X���W��MAX�l
    public const float EnemyXRange = 350f;

    //Enemy�̐��������Y���W
    public const float EnemyYStart = 1100f;

    //Enemy����x�ɑ��݂ł����
    public const�@int poolSize = 5;

    //�w�i�������X�s�[�h
    public const float BackSpeed = 0.5f;
}
