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

    public float GetRotateTime
    { 
        get 
        {
            return _rotateTime;
        }
        private set { }
    }
    public float GetMoveSpeed
    {
        get
        {
            return _moveSpeed;
        }
        private set { }
    }
    public int GetGap
    {
        get
        {
            return (int)(200 / _moveSpeed);
        }
        private set { }
    }

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
