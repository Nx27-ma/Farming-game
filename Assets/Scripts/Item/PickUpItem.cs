
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public Item Item;

    private void OnMouseDown()
    {
        InventoyManager.instance.Add(Item, gameObject);
    }
}
