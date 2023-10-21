using UnityEngine;

public class Food : MonoBehaviour , IInteractable
{
    public void Interact(GameObject interactor)
    {
        if (interactor.GetComponent<GrowthComponent>() == null) return;
        
        interactor.GetComponent<GrowthComponent>().GrowTail();        
        transform.position = FoodSpawner.Instance.Respawn();
    }
}
