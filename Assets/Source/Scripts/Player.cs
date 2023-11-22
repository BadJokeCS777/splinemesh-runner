using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private SplineFollower _follower;
    [SerializeField] private PlayerAnimations _animations;
    
    public event Action Finished;
    public event Action Died;

    public void StartGame()
    {
        _follower.StartMove();
        _animations.SetRun();
    }
    
    public void Finish()
    {
        _follower.StopMove();
        _animations.SetFinish();
        Finished?.Invoke();
    }

    public void Die()
    {
        _follower.StopMove();
        _animations.SetDie();
        Died?.Invoke();
    }
}