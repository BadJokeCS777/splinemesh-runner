using DG.Tweening;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed; 
    [SerializeField] private float _bigSize;
    [SerializeField] private float _increasingDuration;
    [SerializeField] private float _decreasingDuration;

    private void Start()
    {
        float duration = 360f / _rotationSpeed;
        transform.DORotate(transform .eulerAngles + Vector3.up * 180f, duration)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.Linear);
    }
    
    public void PickUp()
    {
        DOTween.Sequence()
            .Append(transform.DOScale( transform.localScale * _bigSize, _increasingDuration))
            .Append(transform.DOScale(0f, _decreasingDuration))
            .onComplete += () => Destroy(gameObject);
    }
}
