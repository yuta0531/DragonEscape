using System.Collections;
using UnityEngine;
using UniRx;

public class EnemyController : MonoBehaviour
{
    //Enemy���I�u�W�F�N�g�v�[���݌v����

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

    //������������Enemy��Pool��
    private void InitializeImagePool()
    {
        imagePool = new GameObject[InGameConst.poolSize];
        for (int i = 0; i < InGameConst.poolSize; i++)
        {
            imagePool[i] = CreateNewImage();
        }
    }

    //Enemy���㕔�Ɉړ�
    private void GenerateRandomImages()
    {
        GameObject newImage = imagePool[currentIndex];

        currentIndex = (currentIndex + 1) % InGameConst.poolSize;

        newImage.SetActive(true);

        RectTransform imageRect = newImage.GetComponent<RectTransform>();
        //Enemy��X���W�̓����_���AY���W�͌Œ�
        float randomX = Random.Range(-InGameConst.EnemyXRange, InGameConst.EnemyXRange);
        imageRect.anchoredPosition = new Vector2(randomX, InGameConst.EnemyYStart);
        imageRect.SetParent(transform, false);
    }

    //Enemy����������
    GameObject CreateNewImage()
    {
        GameObject newImage = Instantiate(imagePrefab);
        newImage.SetActive(false);

        return newImage;
    }

}
