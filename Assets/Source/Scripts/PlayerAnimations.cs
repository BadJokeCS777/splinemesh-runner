using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public void SetRun()
    {
        _animator.SetTrigger("Run");
    }

    public void SetFinish()
    {
        _animator.SetTrigger("Finish");
    }

    public void SetDie()
    {
        _animator.SetTrigger("Die");
    }
}
