using TMPro;
using UnityEngine;

public class FinishView : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Canvas _finishCanvas;
    [SerializeField] private Canvas _gameCanvas;
    [SerializeField] private TMP_Text _resultText;

    private void OnEnable()
    {
        _player.Finished += OnFinished;
    }

    private void OnDisable()
    {
        _player.Finished -= OnFinished;
    }

    private void OnFinished()
    {
        _finishCanvas.gameObject.SetActive(true);
        _gameCanvas.gameObject.SetActive(false);
        _resultText.text = "Reward:\n" + _player.Money;
    }
}
