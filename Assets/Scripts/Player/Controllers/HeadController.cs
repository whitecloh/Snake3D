using UnityEngine;

public class HeadController : MonoBehaviour , IControllable
{
    private Snake _snake;
    private float _rotateTime;
    private float _moveSpeed;
    private Rigidbody rb;
    private void Awake()
    {
        _snake = GetComponentInParent<Snake>();
        _rotateTime = _snake.GetRotateTime;
        _moveSpeed = _snake.GetMoveSpeed;
        rb = _snake.GetRigibody;
    }

    private void FixedUpdate()
    {
        Move();
    }

    public void Rotation(Vector2 direction)
    {
        var rotY = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
        Quaternion targetRot = Quaternion.Euler(0, rotY, 0);
        transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRot, _rotateTime * Time.deltaTime);
    }
    public void Move()
    {
        rb.MovePosition(rb.position + _snake.Head.TransformDirection(new Vector3(0, 0, _moveSpeed)) * Time.deltaTime);
    }
}
