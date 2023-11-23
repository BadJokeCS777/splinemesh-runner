using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private float _jumpHeight;
    [SerializeField] private float _jumpDuration;
    [SerializeField] private float _fallingPosition;
    [SerializeField] private float _fallingDuration;

    public event Action Click;

    private void Start()
    {
        _button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        _button.onClick.RemoveListener(OnClick);
        Click?.Invoke();

        RectTransform rectTransform = (RectTransform) transform;
        DOTween.Sequence()
            .Append(rectTransform.DOAnchorPosY(_jumpHeight, _jumpDuration))
            .Append(rectTransform.DOAnchorPosY(_fallingPosition, _fallingDuration))
            .onComplete += () => gameObject.SetActive(false);
    }
}