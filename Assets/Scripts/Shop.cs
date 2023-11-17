using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public static Shop instance;
    public TextMeshProUGUI SellAmound;
    public TextMeshProUGUI GeldAmound;
    public int Geld;

    public Sprite empty;
    private void Awake()
    {
        instance = this;
    }

    void Update()
    {
        switch (InventoyManager.instance.Inventory[5].itemName)
        {
            case ItemName.Green: 
            case ItemName.Green_Seed:
                SellAmound.text = "$ 1";
                break;
            case ItemName.Grass:
            case ItemName.Grass_Seed:
                SellAmound.text = "$ 2";
                break;
            case ItemName.Wheat:
            case ItemName.Wheat_Seed:
                SellAmound.text = "$ 4";
                break;
            case ItemName.Carrot:
            case ItemName.Carrot_Seed:
                SellAmound.text = "$ 8";
                break;
            case ItemName.Potato:
            case ItemName.Potato_Seed:
                SellAmound.text = "$ 16";
                break;
            case ItemName.Tomato:
            case ItemName.Tomato_Seed:
                SellAmound.text = "$ 32";
                break;
            case ItemName.Berrie:
            case ItemName.Berrie_Seed:
                SellAmound.text = "$ 64";
                break;
            case ItemName.Melon:
            case ItemName.Melon_Seed:
                SellAmound.text = "$ 128";
                break;
            case ItemName.Pumpkin:
            case ItemName.Pumpkin_Seed:
                SellAmound.text = "$ 256";
                break;
            case ItemName.Beetroot:
            case ItemName.Beetroot_Seed:
                SellAmound.text = "$ 512";
                break;
            case ItemName.Cabbage:
            case ItemName.Cabbage_Seed:
                SellAmound.text = "$ 1024";
                break;
            case ItemName.Spinach:
            case ItemName.Spinach_Seed:
                SellAmound.text = "$ 2048";
                break;
            case ItemName.Empty:
                SellAmound.text = "$ 0";
                break;
        }
    }

    public void Sell()
    {
        switch (InventoyManager.instance.Inventory[5].itemName)
        {
            case ItemName.Green:
            case ItemName.Green_Seed:
                Geld += 1;
                break;
            case ItemName.Grass:
            case ItemName.Grass_Seed:
                Geld += 2;
                break;
            case ItemName.Wheat:
            case ItemName.Wheat_Seed:
                Geld += 4;
                break;
            case ItemName.Carrot:
            case ItemName.Carrot_Seed:
                Geld += 8;
                break;
            case ItemName.Potato:
            case ItemName.Potato_Seed:
                Geld += 16;
                break;
            case ItemName.Tomato:
            case ItemName.Tomato_Seed:
                Geld += 32;
                break;
            case ItemName.Berrie:
            case ItemName.Berrie_Seed:
                Geld += 64;
                break;
            case ItemName.Melon:
            case ItemName.Melon_Seed:
                Geld += 128;
                break;
            case ItemName.Pumpkin:
            case ItemName.Pumpkin_Seed:
                Geld += 256;
                break;
            case ItemName.Beetroot:
            case ItemName.Beetroot_Seed:
                Geld += 512;
                break;
            case ItemName.Cabbage:
            case ItemName.Cabbage_Seed:
                Geld += 1024;
                break;
            case ItemName.Spinach:
            case ItemName.Spinach_Seed:
                Geld += 2048;
                break;
        }

        GeldAmound.text = "$ " + Geld.ToString();

        InventoyManager.instance.Inventory[5].itemName = ItemName.Empty;
        InventoyManager.instance.Inventory[5].itemImage = empty;
    }
}
