using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPresenter : MonoBehaviour
{
    private PlayerModel _model;

    [SerializeField]
    private PlayerView _view;

    [SerializeField]
    private InputView _input;

    [SerializeField]
    private InGameStatus _status;


    private void Start()
    {
        _model = new PlayerModel();
        _status.isAlreadyHit = false;
        _view.Initialize();
    }

    private void Update()
    {
        MovePlayer();
        _view.ManualUpdate(_status.isAlreadyHit);
    }

    private void MovePlayer()
    {   
        _model.Move(_input.GetMovementInput(), _status.isAlreadyHit);
        _view.UpdatePosition(_model.Pos_X, _status.isAlreadyHit);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        _view.HitEnemy(other);
        _status.isAlreadyHit = true;
    }

}