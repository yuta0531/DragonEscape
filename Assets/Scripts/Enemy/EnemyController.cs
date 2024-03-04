using System.Collections;
using UnityEngine;
using UniRx;

public class EnemyController : MonoBehaviour
{
    //Enemyをオブジェクトプール設計する

    public GameObject imagePrefab;

    private GameObject[] imagePool;

    private int currentIndex = 0;

    private void Start()
    {
        InitializeImagePool();

        Observable.Interval(System.TimeSpan.FromSeconds(InGameConst.generationInterval))
            .Subscribe(_ => GenerateRandomImages())
            .AddTo(this);
    }

    //初期生成したEnemyをPoolへ
    private void InitializeImagePool()
    {
        imagePool = new GameObject[InGameConst.poolSize];
        for (int i = 0; i < InGameConst.poolSize; i++)
        {
            imagePool[i] = CreateNewImage();
        }
    }

    //Enemyを上部に移動
    private void GenerateRandomImages()
    {
        GameObject newImage = imagePool[currentIndex];

        currentIndex = (currentIndex + 1) % InGameConst.poolSize;

        newImage.SetActive(true);

        RectTransform imageRect = newImage.GetComponent<RectTransform>();
        //EnemyのX座標はランダム、Y座標は固定
        float randomX = Random.Range(-InGameConst.EnemyXRange, InGameConst.EnemyXRange);
        imageRect.anchoredPosition = new Vector2(randomX, InGameConst.EnemyYStart);
        imageRect.SetParent(transform, false);
    }

    //Enemyを初期生成
    GameObject CreateNewImage()
    {
        GameObject newImage = Instantiate(imagePrefab);
        newImage.SetActive(false);

        return newImage;
    }

}
