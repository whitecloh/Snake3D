using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public static FoodSpawner Instance;

    [SerializeField]
    private float _sphereRadius;
    [SerializeField]
    private GameObject _foodPrefab;
    [SerializeField]
    private int _foodAmount; 

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        for(int i=0;i<_foodAmount;i++)
        {
            Initialize();
        }
    }

    private void Initialize()
    {
        Instantiate(_foodPrefab, Respawn(), Quaternion.identity,transform);
    }

    public Vector3 Respawn()
    {
        return Random.onUnitSphere * _sphereRadius;
    }
}
