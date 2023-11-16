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
    
    public List<Sprite> Images = new List<Sprite>();    

    public int selectedslot;

    public GameObject ItemImg1;
    public GameObject ItemImg2;
    public GameObject ItemImg3;
    public GameObject ItemImg4;
    public GameObject ItemImg5;

    public GameObject SlotBackground1;
    public GameObject SlotBackground2;
    public GameObject SlotBackground3;

    public Image HotbarBackground;

    public GameObject SlotTxt1; 
    public GameObject SlotTxt2; 
    public GameObject SlotTxt3;

    public GameObject ShedGui;

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
        Inventory.Add(CreateGieter());
        Inventory.Add(CreateOnkruit());
    }

    private Item CreateEmptyItem()
    {
        Item newItem = ScriptableObject.CreateInstance<Item>();
        newItem.itemName =  ItemName.Empty;
        newItem.itemImage = Images[0];
        newItem.itemType = ItemType.Empty;

        return newItem;
    }

    private Item CreateBeginItem()
    {
        Item newItem = ScriptableObject.CreateInstance<Item>();
        newItem.itemName =  ItemName.Green;
        newItem.itemImage = Images[1];
        newItem.itemType = ItemType.Crop;

        return newItem;
    }

    private Item CreateGieter()
    {
        Item newItem = ScriptableObject.CreateInstance<Item>();
        newItem.itemName = ItemName.Gieter;
        newItem.itemImage = Images[2];
        newItem.itemType = ItemType.Tool;

        return newItem;
    }

    private Item CreateOnkruit()
    {
        Item newItem = ScriptableObject.CreateInstance<Item>();
        newItem.itemName = ItemName.Onkruidverwijderaar;
        newItem.itemImage = Images[3];
        newItem.itemType = ItemType.Tool;

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

    public void HotbarShetSwap()
    {
        if (ShedGui.activeSelf == true)
        {
            if (Inventory[0].itemName == ItemName.Gieter)
            {
                Inventory[3].itemName = Inventory[0].itemName;
                Inventory[3].itemImage = Inventory[0].itemImage;
                Inventory[0].itemName = ItemName.Empty;
                Inventory[0].itemImage = Images[0];
            }
            else if (Inventory[0].itemName == ItemName.Onkruidverwijderaar)
            {
                Inventory[4].itemName = Inventory[0].itemName;
                Inventory[4].itemImage = Inventory[0].itemImage;
                Inventory[0].itemName = ItemName.Empty;
                Inventory[0].itemImage = Images[0];
            }
        }
    }

    public void ShedHotbarSwap(Button button)
    {
        if (Inventory[0].itemName == ItemName.Empty)
        {
            if (button.name == "Slot4")
            {
                Inventory[0].itemName = Inventory[3].itemName;
                Inventory[0].itemImage = Inventory[3].itemImage;
                Inventory[3].itemName = ItemName.Empty;
                Inventory[3].itemImage = Images[0];
            }

            if (button.name == "Slot5")
            {
                Inventory[0].itemName = Inventory[4].itemName;
                Inventory[0].itemImage = Inventory[4].itemImage;
                Inventory[4].itemName = ItemName.Empty;
                Inventory[4].itemImage = Images[0];
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
        ItemImg1.GetComponent<Image>().sprite = Inventory[0].itemImage;
        ItemImg2.GetComponent<Image>().sprite = Inventory[1].itemImage;
        ItemImg3.GetComponent<Image>().sprite = Inventory[2].itemImage;
        ItemImg4.GetComponent<Image>().sprite = Inventory[3].itemImage;
        ItemImg5.GetComponent<Image>().sprite = Inventory[4].itemImage;

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

        if (Input.GetKeyDown(KeyCode.Q))
        {
            for (int i = 0; i < ItemObj.Count; i++)
            {
                if (Inventory[selectedslot].itemName.ToString() == ItemScripObj[i].itemName.ToString())
                {
                    GameObject Item = Instantiate(ItemObj[i]);
                    Item.transform.position = Player.position;

                    Inventory[selectedslot].itemName = ItemName.Empty;
                    Inventory[selectedslot].itemImage = Images[0];
                }
            }
        }
    }
}
