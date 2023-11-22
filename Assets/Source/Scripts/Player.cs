using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private SplineFollower _follower;
    [SerializeField] private PlayerAnimations _animations;

    public int Money { get; private set; }

    public event UnityAction MoneyChanged;

    public void StartGame()
    {
        _follower.StartMove();
        _animations.SetRun();
    }
    
    public void Finish()
    {
        _follower.StopMove();
        _animations.SetFinish();
    }

    public void Die()
    {
        _follower.StopMove();
        _animations.SetDie();
    }

    public void AddMoney()
    {
        Money++;
        MoneyChanged?.Invoke();
    }
}
