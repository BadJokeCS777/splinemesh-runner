using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out SplineFollower follower))
        {
            Debug.Log("Finished");
        }
    }
}
