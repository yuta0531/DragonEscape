using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPresenter : MonoBehaviour
{
    [SerializeField]
    private EnemyView _view;

    private InGameStatus _status;

    private void Start()
    {
        _view.Initialize();
        _status = FindObjectOfType<InGameStatus>();
    }

    private void Update()
    {
        _view.ManualUpdate(_status.isAlreadyHit);
    }
}