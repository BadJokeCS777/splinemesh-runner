using DG.Tweening;
using UnityEngine;

public class EndPanelAnimation : MonoBehaviour
{
    [SerializeField] private EndPanelAnimationStep[] _steps;
    
    public void Play()
    {
        Sequence sequence = DOTween.Sequence();

        foreach (EndPanelAnimationStep step in _steps)
            sequence.Append(transform.DOScale(step.Scale, step.Duration));
    }
}