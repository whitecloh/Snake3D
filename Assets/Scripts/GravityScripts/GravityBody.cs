using UnityEngine;

public class GravityBody : MonoBehaviour
{
    private GravityAttractor _attractor;

    private void Awake()
    {
        _attractor = FindObjectOfType<GravityAttractor>();
    }

    private void Update()
    {
        _attractor.Attract(transform);
    }
}
