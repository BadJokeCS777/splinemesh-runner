using UnityEngine;

public class ChestTrigger : MonoBehaviour
{
    [SerializeField] private ChestAnimation _animation;

    private bool _isOpebed;

    private void OnTriggerStay(Collider other)
    {
        if (_isOpebed)
            return;

        if (!other.TryGetComponent(out PlayerMovement movement))
            return;
        
        if (Input.GetKey(KeyCode.E))
        {
            _isOpebed = true;
            _animation.Run();
        }
    }
}