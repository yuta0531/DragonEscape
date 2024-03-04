using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePresenter : MonoBehaviour
{
    public static ScorePresenter instance;
    private ScoreModel _model;

    [SerializeField]
    private InGameStatus _status;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;//instanceÅ®ScoreResultÇ≈égóp
        }
    }

    void Start()
    {
        _model = new ScoreModel();
        _model.ScoreReset();
    }


    void Update()
    {
        _model.ScoreCount(_status.isAlreadyHit);
    }

    public float ScoreResultValue()
    {
        return _model.ScoreValue;
    }
}
