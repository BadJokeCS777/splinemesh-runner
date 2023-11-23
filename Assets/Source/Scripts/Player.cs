using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private SplineFollower _follower;
    [SerializeField] private PlayerAnimator _animator;
    
    public event Action Finished;
    public event Action Died;

    public void StartLevel()
    {
        _follower.Enable();
        _animator.SetRun();
    }
    
    public void Finish()
    {
        _follower.Disable();
        _animator.SetFinish();
        Finished?.Invoke();
    }

    public void Die()
    {
        _follower.Disable();
        _animator.SetDie();
        Died?.Invoke();
    }
}