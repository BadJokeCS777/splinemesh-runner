using UnityEngine;
using UnityEngine.Events;

public class Obstacle : MonoBehaviour
{
    public event UnityAction Reached;

    private bool _isReached;
    
    private void OnTriggerEnter(Collider other)
    {
        if (!_isReached && other.TryGetComponent(out Player player))
        {
            _isReached = true;
            player.Die();
            Reached?.Invoke();
        }
    }
}
