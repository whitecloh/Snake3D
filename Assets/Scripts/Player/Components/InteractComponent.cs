using UnityEngine;

public class InteractComponent : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        var food = collision.gameObject.GetComponent<Food>();
        if (food != null)
        {
            food.Interact(gameObject);
        }
    }
}
