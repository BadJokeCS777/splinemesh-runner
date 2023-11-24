using UnityEngine;

public class ChestAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public void Run()
    {
        _animator.SetTrigger("Run");
    }
}
