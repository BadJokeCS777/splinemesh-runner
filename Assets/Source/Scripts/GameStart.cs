using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
    [FormerlySerializedAs("_follower")] [SerializeField] private Player _player;
    [SerializeField] private Button _button;

    private void OnEnable()
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
