using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

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

    public ScriptableObject Green;
    public ScriptableObject Grass;
    public ScriptableObject Wheat;
    public ScriptableObject Carrot;
    public ScriptableObject Potato;
    public ScriptableObject Tomato;
    public ScriptableObject Berrie;
    public ScriptableObject Melon;
    public ScriptableObject Pumpkin;
    public ScriptableObject Beetroot;
    public ScriptableObject Cabbage;

    public void TradeGrass()
    {
        if (InventoyManager.instance.items[1] == Green && InventoyManager.instance.items[2] == Green)
        {
            InventoyManager.instance.items[1].itemName = ItemName.Grass_Seed;
            InventoyManager.instance.items[1].itemImage = Grass_Seed;

            InventoyManager.instance.items[2].itemName = ItemName.Empty;
            InventoyManager.instance.items[2].itemImage = InventoyManager.instance.EmptySlot;
        }
    }

    public void TradeWheat()
    {
        if (InventoyManager.instance.items[1] == Grass && InventoyManager.instance.items[2] == Grass)
        {
            InventoyManager.instance.items[1].itemName = ItemName.Wheat_Seed;
            InventoyManager.instance.items[1].itemImage = Wheat_Seed;

            InventoyManager.instance.items[2].itemName = ItemName.Empty;
            InventoyManager.instance.items[2].itemImage = InventoyManager.instance.EmptySlot;
        }
    }

    public void TradeCarrot()
    {
        if (InventoyManager.instance.items[1] == Wheat && InventoyManager.instance.items[2] == Wheat)
        {
            InventoyManager.instance.items[1].itemName = ItemName.Carrot_Seed;
            InventoyManager.instance.items[1].itemImage = Carrot_Seed;

            InventoyManager.instance.items[2].itemName = ItemName.Empty;
            InventoyManager.instance.items[2].itemImage = InventoyManager.instance.EmptySlot;
        }
    }

    public void TradePotato()
    {
        if (InventoyManager.instance.items[1] == Carrot && InventoyManager.instance.items[2] == Carrot)
        {
            InventoyManager.instance.items[1].itemName = ItemName.Potato_Seed;
            InventoyManager.instance.items[1].itemImage = Potato_Seed;

            InventoyManager.instance.items[2].itemName = ItemName.Empty;
            InventoyManager.instance.items[2].itemImage = InventoyManager.instance.EmptySlot;
        }
    }

    public void TradeTomato()
    {
        if (InventoyManager.instance.items[1] == Potato && InventoyManager.instance.items[2] == Potato)
        {
            InventoyManager.instance.items[1].itemName = ItemName.Tomato_Seed;
            InventoyManager.instance.items[1].itemImage = Tomato_Seed;

            InventoyManager.instance.items[2].itemName = ItemName.Empty;
            InventoyManager.instance.items[2].itemImage = InventoyManager.instance.EmptySlot;
        }
    }

    public void TradeBerrie()
    {
        if (InventoyManager.instance.items[1] == Tomato && InventoyManager.instance.items[2] == Tomato)
        {
            InventoyManager.instance.items[1].itemName = ItemName.Berrie_Seed;
            InventoyManager.instance.items[1].itemImage = Berrie_Seed;

            InventoyManager.instance.items[2].itemName = ItemName.Empty;
            InventoyManager.instance.items[2].itemImage = InventoyManager.instance.EmptySlot;
        }
    }

    public void TradeMelon()
    {
        if (InventoyManager.instance.items[1] == Berrie && InventoyManager.instance.items[2] == Berrie)
        {
            InventoyManager.instance.items[1].itemName = ItemName.Melon_Seed;
            InventoyManager.instance.items[1].itemImage = Melon_Seed;

            InventoyManager.instance.items[2].itemName = ItemName.Empty;
            InventoyManager.instance.items[2].itemImage = InventoyManager.instance.EmptySlot;
        }
    }

    public void TradePumpkin()
    {
        if (InventoyManager.instance.items[1] == Melon && InventoyManager.instance.items[2] == Melon)
        {
            InventoyManager.instance.items[1].itemName = ItemName.Pumpkin_Seed;
            InventoyManager.instance.items[1].itemImage = Pumpkin_Seed;

            InventoyManager.instance.items[2].itemName = ItemName.Empty;
            InventoyManager.instance.items[2].itemImage = InventoyManager.instance.EmptySlot;
        }
    }
    public void TradeBeetroot()
    {
        if (InventoyManager.instance.items[1] == Pumpkin && InventoyManager.instance.items[2] == Pumpkin)
        {
            InventoyManager.instance.items[1].itemName = ItemName.Beetroot_Seed;
            InventoyManager.instance.items[1].itemImage = Beetroot_Seed;

            InventoyManager.instance.items[2].itemName = ItemName.Empty;
            InventoyManager.instance.items[2].itemImage = InventoyManager.instance.EmptySlot;
        }
    }


    public void TradeCabbage()
    {
        if (InventoyManager.instance.items[1] == Beetroot && InventoyManager.instance.items[2] == Beetroot)
        {
            InventoyManager.instance.items[1].itemName = ItemName.Cabbage_Seed;
            InventoyManager.instance.items[1].itemImage = Cabbage_Seed;

            InventoyManager.instance.items[2].itemName = ItemName.Empty;
            InventoyManager.instance.items[2].itemImage = InventoyManager.instance.EmptySlot;
        }
    }

    public void TradeSpinch()
    {
        if (InventoyManager.instance.items[1] == Cabbage && InventoyManager.instance.items[2] == Cabbage)
        {
            InventoyManager.instance.items[1].itemName = ItemName.Spinach_Seed;
            InventoyManager.instance.items[1].itemImage = Spinach_Seed;

            InventoyManager.instance.items[2].itemName = ItemName.Empty;
            InventoyManager.instance.items[2].itemImage = InventoyManager.instance.EmptySlot;
        }
    }
}
