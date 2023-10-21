using UnityEngine;

public class GrowthComponent : MonoBehaviour ,ICanGrow
{
    [SerializeField]
    private GameObject _tailPrefab;
    [SerializeField]
    private Transform _snakeTailHolder;

    private Snake _snake;

    private void Awake()
    {
        _snake = GetComponent<Snake>();
    }
    public void GrowTail()
    {
        var body = Instantiate(_tailPrefab, _snakeTailHolder.position, Quaternion.identity, _snakeTailHolder);
        _snake.TailParts.Add(body);
    }

}
