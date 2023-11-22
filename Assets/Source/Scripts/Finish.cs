using UnityEngine;
using UnityEngine.Events;

public class Finish : MonoBehaviour
{
    public event UnityAction Reached;

    private bool _isFinished;
    
    private void OnTriggerEnter(Collider other)
    {
        if (!_isFinished && other.TryGetComponent(out Player player))
        {
            _isFinished = true;
            player.Finish();
            Reached?.Invoke();
        }
    }
}
