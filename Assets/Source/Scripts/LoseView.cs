using UnityEngine;

public class LoseView : MonoBehaviour
{
    [SerializeField] private Canvas _loseCanvas;
    
    public void Enable()
    {
        _loseCanvas.gameObject.SetActive(true);
    }
}