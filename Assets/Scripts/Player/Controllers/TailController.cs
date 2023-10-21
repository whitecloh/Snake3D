using System.Collections.Generic;
using UnityEngine;

public class TailController : MonoBehaviour
{
    [SerializeField]
    private Snake _snake;
    private float _moveSpeed;
    private int _gap;

    private List<Vector3> _positionsHistory = new List<Vector3>();

    private void Awake()
    {
        _moveSpeed = _snake.GetMoveSpeed;
        _gap = _snake.GetGap;
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        _positionsHistory.Insert(0, _snake.transform.position);
        int index = 0;
        foreach (var body in _snake.TailParts)
        {
            Vector3 point = _positionsHistory[Mathf.Min(index * _gap, _positionsHistory.Count - 1)];
            Vector3 moveDirection = point - body.transform.position;
            body.transform.position += _moveSpeed * Time.deltaTime * moveDirection;
            body.transform.LookAt(point);
            index++;
        }
    }
}
