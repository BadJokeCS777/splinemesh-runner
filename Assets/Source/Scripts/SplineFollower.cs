using SplineMesh;
using UnityEngine;

public class SplineFollower : MonoBehaviour
{
    [SerializeField] private Spline _spline;
    [SerializeField] private float _speed;
    [SerializeField] private float _sensitivity;
    [SerializeField] private float _startPosition;

    private float _splineRate = 0;
    private float _input = 0;
    private float _lastMousePosition;
    private bool _canMove;

    public void StartMove()
    {
        _lastMousePosition = Input.mousePosition.x;
        _splineRate = _startPosition;
        _canMove = true;
    }

    public void StopMove()
    {
        _canMove = false;
    }

    private void Update()
    {
        if(!_canMove)
            return;
        
        //считываем ввод
        _input += (Input.mousePosition.x - _lastMousePosition) * _sensitivity;
        //запоминаем последнюю позицию мыши
        _lastMousePosition = Input.mousePosition.x;
        //обрезаем значение
        _input = Mathf.Clamp(_input, -1, 1);
        
        //изменение позиции
        _splineRate += Time.deltaTime * _speed;
        
        //если мы не дошли до конца сплайна
        if (_splineRate < _spline.nodes.Count - 1)
        {
            //изменить позицию объекта
            Place();
        }
    }

    private void Place()
    {
        //получаем точку сплайна на основе текущей позиции
        CurveSample sample = _spline.GetSample(_splineRate);

        //передаем в локальные координаты значения с точки сплайна
        transform.localPosition = sample.location;
        transform.localRotation = sample.Rotation;
        
        SetOffset();
    }

    private void SetOffset()
    {
        //назначаем отступ от середины сплайна
        transform.position += transform.right * _input;
    }
}
