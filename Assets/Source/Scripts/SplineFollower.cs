using SplineMesh;
using UnityEngine;

public class SplineFollower : MonoBehaviour
{
    [SerializeField] private Spline _spline;
    [SerializeField] private float _speed;
    [SerializeField] private float _sensitivity;

    private float _splineRate = 0;
    private float _input = 0;
    private float _lastMousePosition;

    private void Start()
    {
        Place();
        Disable();
    }

    public void Enable()
    {
        _lastMousePosition = Input.mousePosition.x;
        enabled = true;
    }

    public void Disable()
    {
        enabled = false;
    }

    private void Update()
    {
        if (_splineRate >= _spline.nodes.Count - 1)
            return;
            
        _input += (Input.mousePosition.x - _lastMousePosition) * _sensitivity;
        _lastMousePosition = Input.mousePosition.x;
        _input = Mathf.Clamp(_input, -1, 1);
        
        Place();
        
        _splineRate += Time.deltaTime * _speed;
    }

    private void Place()
    {
        CurveSample sample = _spline.GetSample(_splineRate);

        transform.localPosition = sample.location + transform.right * _input;
        transform.localRotation = sample.Rotation;
    }
}
