using UnityEngine;

public class InputComponent : MonoBehaviour
{
    [SerializeField]
    private Joystick _joystick;
    [SerializeField]
    private HeadController _player;

    private IControllable _contollableGO;

    private void Awake()
    {
        _contollableGO = _player.GetComponent<IControllable>();
    }

    private void Update()
    {
        if (JoystickInput().x == 0 && JoystickInput().y == 0)
        {
            return;
        }
        _contollableGO.Rotation(JoystickInput().normalized);
    }
    private Vector2 JoystickInput()
    {
        return new Vector2(_joystick.Horizontal, _joystick.Vertical);
    }
}
