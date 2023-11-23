using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private WinView _winView;
    [SerializeField] private LoseView _loseView;
    [SerializeField] private LevelCanvas _levelCanvas;

    private void Start()
    {
        _player.Finished += OnFinished;
        _player.Died += OnDied;
    }

    private void OnFinished()
    {
        End();
        _winView.Enable();
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
        _levelCanvas.Disable();
    }
}