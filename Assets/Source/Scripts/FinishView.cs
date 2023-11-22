using UnityEngine;

public class FinishView : MonoBehaviour
{
    [SerializeField] private Finish _finish;
    [SerializeField] private GameObject _finishPanel;

    private void OnEnable()
    {
        _finish.Reached += OnReached;
    }

    private void OnDisable()
    {
        _finish.Reached -= OnReached;
    }

    private void OnReached()
    {
        _finishPanel.gameObject.SetActive(true);
    }
}
