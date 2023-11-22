using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private FinishView _finishView;
    [SerializeField] private LoseView _loseView;
    [SerializeField] private GameCanvas _gameCanvas;

    private void Start()
    {
        _player.Finished += OnFinished;
        _player.Died += OnDied;
    }

    private void OnFinished()
    {
        End();
        _finishView.Enable();
    }

    private void OnDied()
    {
        End();
        _loseView.Enable();
    }

    private void End()
    {
        _player.Finished -= OnFinished;
        _player.Died -= OnDied;
        _gameCanvas.Disable();
    }
}