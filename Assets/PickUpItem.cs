
using UnityEngine;


public class PickUpItem : MonoBehaviour
{

    public Item Item;

    void PickUp()
    {
        InventoyManager.instance.Add(Item, gameObject);
    }

    private void OnMouseDown()
    {
        PickUp();
    }
}
