using DG.Tweening;
using UnityEngine;

public class LevelCanvas : MonoBehaviour
{
    [SerializeField] private CanvasGroup _wallet;
    [SerializeField] private float _fadeDuration;
    
    public void Disable()
    {
        _wallet.DOFade(0f, _fadeDuration)
            .onComplete += () => gameObject.SetActive(false);
    }
}