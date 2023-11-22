using UnityEngine;
using UnityEngine.UI;

public class LevelStart : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Button _button;

    private void Start()
    {
        _button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        _player.StartGame();
        _button.onClick.RemoveListener(OnButtonClick);
        _button.gameObject.SetActive(false);
    }
}
