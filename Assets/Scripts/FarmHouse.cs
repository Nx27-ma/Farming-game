using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;
using static UnityEditor.Progress;

public class FarmHouse : MonoBehaviour
{
    public Sprite Grass_Seed;
    public Sprite Wheat_Seed;
    public Sprite Carrot_Seed;
    public Sprite Potato_Seed;
    public Sprite Tomato_Seed;
    public Sprite Berrie_Seed;
    public Sprite Melon_Seed;
    public Sprite Pumpkin_Seed;
    public Sprite Beetroot_Seed;
    public Sprite Cabbage_Seed;
    public Sprite Spinach_Seed;

    public void TradeGrass()
    {
        if (InventoyManager.instance.Inventory[1].itemName == ItemName.Green && InventoyManager.instance.Inventory[2].itemName == ItemName.Green)
        {
            InventoyManager.instance.Inventory[1].itemName = ItemName.Grass_Seed;
            InventoyManager.instance.Inventory[1].itemImage = Grass_Seed;

            InventoyManager.instance.Inventory[2].itemName = ItemName.Empty;
            InventoyManager.instance.Inventory[2].itemImage = InventoyManager.instance.Images[0];
        }
    }

    public void TradeWheat()
    {
        if (InventoyManager.instance.Inventory[1].itemName == ItemName.Grass && InventoyManager.instance.Inventory[2].itemName == ItemName.Grass)
        {
            InventoyManager.instance.Inventory[1].itemName = ItemName.Wheat_Seed;
            InventoyManager.instance.Inventory[1].itemImage = Wheat_Seed;

            InventoyManager.instance.Inventory[2].itemName = ItemName.Empty;
            InventoyManager.instance.Inventory[2].itemImage = InventoyManager.instance.Images[0];
        }
    }

    public void TradeCarrot()
    {
        if (InventoyManager.instance.Inventory[1].itemName == ItemName.Wheat && InventoyManager.instance.Inventory[2].itemName == ItemName.Wheat)
        {
            InventoyManager.instance.Inventory[1].itemName = ItemName.Carrot_Seed;
            InventoyManager.instance.Inventory[1].itemImage = Carrot_Seed;

            InventoyManager.instance.Inventory[2].itemName = ItemName.Empty;
            InventoyManager.instance.Inventory[2].itemImage = InventoyManager.instance.Images[0];
        }
    }

    public void TradePotato()
    {
        if (InventoyManager.instance.Inventory[1].itemName == ItemName.Carrot && InventoyManager.instance.Inventory[2].itemName == ItemName.Carrot)
        {
            InventoyManager.instance.Inventory[1].itemName = ItemName.Potato_Seed;
            InventoyManager.instance.Inventory[1].itemImage = Potato_Seed;

            InventoyManager.instance.Inventory[2].itemName = ItemName.Empty;
            InventoyManager.instance.Inventory[2].itemImage = InventoyManager.instance.Images[0];
        }
    }

    public void TradeTomato()
    {
        if (InventoyManager.instance.Inventory[1].itemName == ItemName.Potato && InventoyManager.instance.Inventory[2].itemName == ItemName.Potato)
        {
            InventoyManager.instance.Inventory[1].itemName = ItemName.Tomato_Seed;
            InventoyManager.instance.Inventory[1].itemImage = Tomato_Seed;
            
            InventoyManager.instance.Inventory[2].itemName = ItemName.Empty;
            InventoyManager.instance.Inventory[2].itemImage = InventoyManager.instance.Images[0];
        }
    }

    public void TradeBerrie()
    {
        if (InventoyManager.instance.Inventory[1].itemName == ItemName.Tomato && InventoyManager.instance.Inventory[2].itemName == ItemName.Tomato)
        {
            InventoyManager.instance.Inventory[1].itemName = ItemName.Berrie_Seed;
            InventoyManager.instance.Inventory[1].itemImage = Berrie_Seed;

            InventoyManager.instance.Inventory[2].itemName = ItemName.Empty;
            InventoyManager.instance.Inventory[2].itemImage = InventoyManager.instance.Images[0];
        }
    }

    public void TradeMelon()
    {
        if (InventoyManager.instance.Inventory[1].itemName == ItemName.Berrie && InventoyManager.instance.Inventory[2].itemName == ItemName.Berrie)
        {
            InventoyManager.instance.Inventory[1].itemName = ItemName.Melon_Seed;
            InventoyManager.instance.Inventory[1].itemImage = Melon_Seed;

            InventoyManager.instance.Inventory[2].itemName = ItemName.Empty;
            InventoyManager.instance.Inventory[2].itemImage = InventoyManager.instance.Images[0];
        }
    }

    public void TradePumpkin()
    {
        if (InventoyManager.instance.Inventory[1].itemName == ItemName.Melon && InventoyManager.instance.Inventory[2].itemName == ItemName.Melon)
        {
            InventoyManager.instance.Inventory[1].itemName = ItemName.Pumpkin_Seed;
            InventoyManager.instance.Inventory[1].itemImage = Pumpkin_Seed;

            InventoyManager.instance.Inventory[2].itemName = ItemName.Empty;
            InventoyManager.instance.Inventory[2].itemImage = InventoyManager.instance.Images[0];
        }
    }
    public void TradeBeetroot()
    {
        if (InventoyManager.instance.Inventory[1].itemName == ItemName.Pumpkin && InventoyManager.instance.Inventory[2].itemName == ItemName.Pumpkin)
        {
            InventoyManager.instance.Inventory[1].itemName = ItemName.Beetroot_Seed;
            InventoyManager.instance.Inventory[1].itemImage = Beetroot_Seed;

            InventoyManager.instance.Inventory[2].itemName = ItemName.Empty;
            InventoyManager.instance.Inventory[2].itemImage = InventoyManager.instance.Images[0];
        }
    }


    public void TradeCabbage()
    {
        if (InventoyManager.instance.Inventory[1].itemName == ItemName.Beetroot && InventoyManager.instance.Inventory[2].itemName == ItemName.Beetroot)
        {
            InventoyManager.instance.Inventory[1].itemName = ItemName.Cabbage_Seed;
            InventoyManager.instance.Inventory[1].itemImage = Cabbage_Seed;

            InventoyManager.instance.Inventory[2].itemName = ItemName.Empty;
            InventoyManager.instance.Inventory[2].itemImage = InventoyManager.instance.Images[0];
        }
    }

    public void TradeSpinch()
    {
        if (InventoyManager.instance.Inventory[1].itemName == ItemName.Cabbage && InventoyManager.instance.Inventory[2].itemName == ItemName.Cabbage)
        {
            InventoyManager.instance.Inventory[1].itemName = ItemName.Spinach_Seed;
            InventoyManager.instance.Inventory[1].itemImage = Spinach_Seed;

            InventoyManager.instance.Inventory[2].itemName = ItemName.Empty;
            InventoyManager.instance.Inventory[2].itemImage = InventoyManager.instance.Images[0];
        }
    }
}
