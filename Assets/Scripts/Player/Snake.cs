using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed;
    [SerializeField]
    private float _rotateTime;
    [SerializeField]
    private Transform _head;
    [SerializeField]
    private Rigidbody _rb;
    [SerializeField]
    private int _gap;

    public float GetRotateTime => _rotateTime;
    public float GetMoveSpeed => _moveSpeed;
    public int GetGap => _gap;

    public Rigidbody GetRigibody => _rb;
    public Transform Head => _head;

    private List<GameObject> _tailParts = new List<GameObject>();
    public List<GameObject> TailParts
    {
        get
        {
            return _tailParts;
        }
        set
        {
            _tailParts = value;
        }
    }

}
