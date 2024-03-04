using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameConst : MonoBehaviour
{
    //Playerが左右に移動するスピード
    public const float PlayerMoveSpeed = 500.0f;

    //PlayerとBombのアニメーションのスプライト変更の時間間隔
    public const float SpriteChangeIntervalTime = 0.1f;

    //Enemyが移動するスピード
    public const float EnemyMoveSpeed = -280f;

    //Enemyが生成されるインターバル秒
    public const float generationInterval = 0.8f;

    //Enemyの生成されるX座標のMAX値
    public const float EnemyXRange = 350f;

    //Enemyの生成されるY座標
    public const float EnemyYStart = 1100f;

    //Enemyが一度に存在できる個数
    public const　int poolSize = 5;

    //背景が動くスピード
    public const float BackSpeed = 0.5f;
}
