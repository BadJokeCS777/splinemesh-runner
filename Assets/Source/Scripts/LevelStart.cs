using UnityEngine;

public class LevelStart : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private StartButton _button;

    private void Start()
    {
        _button.Click += OnClick;
    }

    private void OnClick()
    {
        _button.Click -= OnClick;
        _player.StartLevel();
    }
}