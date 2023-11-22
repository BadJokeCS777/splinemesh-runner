using UnityEngine;

public class LoseView : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Canvas _loseCanvas;
    [SerializeField] private Canvas _gameCanvas;
    
    private void OnEnable()
    {
        _player.Losed += OnLosed;
    }

    private void OnDisable()
    {
        _player.Losed -= OnLosed;
    }

    private void OnLosed()
    {
        _loseCanvas.gameObject.SetActive(true);
        _gameCanvas.gameObject.SetActive(false);
    }
}
