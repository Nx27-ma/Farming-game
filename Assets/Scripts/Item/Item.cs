using UnityEngine;
public enum ItemType
{
    Tool,
    Crop,
    Empty
}

public enum ItemName
{
    Empty,
    Green,
    Green_Seed,
    Grass,
    Grass_Seed,
    Wheat,
    Wheat_Seed,
    Carrot,
    Carrot_Seed,
    Potato,
    Potato_Seed,
    Tomato,
    Tomato_Seed,
    Berrie,
    Berrie_Seed,
    Melon,
    Melon_Seed,
    Pumpkin,
    Pumpkin_Seed,
    Beetroot,
    Beetroot_Seed,
    Cabbage,
    Cabbage_Seed,
    Spinach,
    Spinach_Seed,
    Gieter,
    Onkruidverwijderaar
}

[CreateAssetMenu(fileName = "New Inventory Item", menuName = "Inventory/Inventory Item")]
public class Item : ScriptableObject
{
    public ItemName itemName;
    public Sprite itemImage;
    public ItemType itemType;
}
