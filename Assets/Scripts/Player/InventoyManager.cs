using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class InventoyManager : MonoBehaviour
{
    public static InventoyManager instance;
    public List<Item> Inventory = new List<Item>();

    public List<Item> ItemScripObj = new List<Item>();

    public List<GameObject> ItemObj = new List<GameObject>();
    
    public int selectedslot;

    public GameObject ItemImg1;
    public GameObject ItemImg2;
    public GameObject ItemImg3;
    public GameObject ItemImg4;
    public GameObject ItemImg5;

    public GameObject SlotBackground1;
    public GameObject SlotBackground2;
    public GameObject SlotBackground3;

    public GameObject SlotTxt1; 
    public GameObject SlotTxt2; 
    public GameObject SlotTxt3;

    public GameObject ShedGui;
    
    public Sprite EmptySlot;
    public Sprite StartItem;

    public Transform Player;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        Inventory.Add(CreateEmptyItem());
        Inventory.Add(CreateBeginItem());
        Inventory.Add(CreateBeginItem());
    }

    private Item CreateEmptyItem()
    {
        Item newItem = ScriptableObject.CreateInstance<Item>();
        newItem.itemName =  ItemName.Empty;
        newItem.itemImage = EmptySlot;
        newItem.itemType = ItemType.Empty;

        return newItem;
    }

    private Item CreateBeginItem()
    {
        Item newItem = ScriptableObject.CreateInstance<Item>();
        newItem.itemName =  ItemName.Green;
        newItem.itemImage = StartItem;
        newItem.itemType = ItemType.Crop;

        return newItem;
    }

    public void SetSelected(Button button)
    {
        SlotBackground1.GetComponent<Image>().color = new Color32(0, 0, 0, 0);
        SlotBackground2.GetComponent<Image>().color = new Color32(0, 0, 0, 0);
        SlotBackground3.GetComponent<Image>().color = new Color32(0, 0, 0, 0);
        switch (button.name)
        {
            case "Slot1":
                selectedslot = 0;
                SlotBackground1.GetComponent<Image>().color = new Color32(255, 0, 0, 20);
                break;
            case "Slot2":
                selectedslot = 1;
                SlotBackground2.GetComponent<Image>().color = new Color32(255, 0, 0, 20);
                break;
            case "Slot3":
                selectedslot = 2;
                SlotBackground3.GetComponent<Image>().color = new Color32(255, 0, 0, 20);
                break;
        }
    }

    public void ShetSwap()
    {
        Debug.Log("test");
        Debug.Log(ShedGui.activeSelf);
        if (ShedGui.activeSelf == true)
        {
            Debug.Log("active");
            if (Inventory[3].itemName == ItemName.Empty)
            {
                Inventory[3].itemName = Inventory[0].itemName;
                Inventory[3].itemImage = Inventory[0].itemImage;
                Inventory[0].itemName = ItemName.Empty;
                Inventory[0].itemImage = EmptySlot;
            }
            else if (Inventory[4].itemName == ItemName.Empty)
            {
                Inventory[4].itemName = Inventory[0].itemName;
                Inventory[4].itemImage = Inventory[0].itemImage;
                Inventory[0].itemName = ItemName.Empty;
                Inventory[0].itemImage = EmptySlot;
            }
        }
    }

    public void Add(Item item, GameObject itemObject)
    {
        if (item.itemType == ItemType.Tool)
        {
            if (Inventory[0].itemName == ItemName.Empty)
            {
                Inventory[0].itemName = item.itemName;
                Inventory[0].itemImage = item.itemImage;
                Destroy(itemObject);
            }
        }

        if (item.itemType == ItemType.Crop)
        {
            if (Inventory[1].itemName == ItemName.Empty)
            {
                Inventory[1].itemName = item.itemName;
                Inventory[1].itemImage = item.itemImage;
                Destroy(itemObject);
            }
            else
            {
                if (Inventory[2].itemName == ItemName.Empty)
                {
                    Inventory[2].itemName = item.itemName;
                    Inventory[2].itemImage = item.itemImage;
                    Destroy(itemObject);
                }
            }
        }
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            SlotBackground1.GetComponent<Image>().color = new Color32(0, 0, 0, 0);
            SlotBackground2.GetComponent<Image>().color = new Color32(0, 0, 0, 0);
            SlotBackground3.GetComponent<Image>().color = new Color32(0, 0, 0, 0);
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                selectedslot = 0;
                SlotBackground1.GetComponent<Image>().color = new Color32(255, 0, 0, 20);
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                selectedslot = 1;
                SlotBackground2.GetComponent<Image>().color = new Color32(255, 0, 0, 20);
            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                selectedslot = 2;
                SlotBackground3.GetComponent<Image>().color = new Color32(255, 0, 0, 20);
            }
        }

        ItemImg1.GetComponent<Image>().sprite = Inventory[0].itemImage;
        ItemImg2.GetComponent<Image>().sprite = Inventory[1].itemImage;
        ItemImg3.GetComponent<Image>().sprite = Inventory[2].itemImage;



        if (Input.GetKeyDown(KeyCode.Q))
        {
            for (int i = 0; i < ItemObj.Count; i++)
            {
                if (Inventory[selectedslot].itemName.ToString() == ItemScripObj[i].itemName.ToString())
                {
                    GameObject Item = Instantiate(ItemObj[i]);
                    Item.transform.position = Player.position;

                    Inventory[selectedslot].itemName = ItemName.Empty;
                    Inventory[selectedslot].itemImage = EmptySlot;
                }
            }
        }
    }
}
