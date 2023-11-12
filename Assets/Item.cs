using UnityEngine;

public enum ItemType
{
    Tool,
    Crop,
    Empty
}

[CreateAssetMenu(fileName = "New Inventory Item", menuName = "Inventory/Inventory Item")]
public class Item : ScriptableObject
{
    public string itemName;
    public Sprite itemImage;
    public ItemType itemType;
}
