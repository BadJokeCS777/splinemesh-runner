using UnityEngine;

public class LoseView : MonoBehaviour
{
    [SerializeField] private Obstacle _obstacle;
    [SerializeField] private GameObject _losePanel;

    private void OnEnable()
    {
        _obstacle.Reached += OnReached;
    }

    private void OnDisable()
    {
        _obstacle.Reached -= OnReached;
    }

    private void OnReached()
    {
        _losePanel.gameObject.SetActive(true);
    }
}
