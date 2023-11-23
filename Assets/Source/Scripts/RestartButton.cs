using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour
{
    [SerializeField] private Button _button;

    private void Start()
    {
        _button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        _button.onClick.RemoveListener(OnButtonClick);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
