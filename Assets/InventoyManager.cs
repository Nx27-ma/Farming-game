using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class InventoyManager : MonoBehaviour
{
    public static InventoyManager instance;
    public List<Item> items = new List<Item>();

    public GameObject Green;
    public GameObject Grass;
    public GameObject Wheat;
    public GameObject Carrot;
    public GameObject Potato;
    public GameObject Tomato;
    public GameObject berrie;
    public GameObject Melon;
    public GameObject Pumpkin;
    public GameObject Beetroot;
    public GameObject Cabbage;
    public GameObject Spanich;

    public GameObject Green_Seed;
    public GameObject Grass_Seed;
    public GameObject Wheat_Seed;
    public GameObject Carrot_Seed;
    public GameObject Potato_Seed;
    public GameObject Tomato_Seed;
    public GameObject berrie_Seed;
    public GameObject Melon_Seed;
    public GameObject Pumpkin_Seed;
    public GameObject Beetroot_Seed;
    public GameObject Cabbage_Seed;
    public GameObject Spanich_Seed;

    public GameObject Gieter;
    public GameObject mortaronkruidverwijderaar;

    public int selectedslot;
    public GameObject SlotImg1;
    public GameObject SlotImg2;
    public GameObject SlotImg3;

    public Sprite EmptySlot;
    public Sprite StartItem;
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        items.Add(CreateEmptyItem());
        items.Add(CreateEmptyItem());
        items.Add(CreateEmptyItem());
    }

    private Item CreateEmptyItem()
    {
        Item newItem = ScriptableObject.CreateInstance<Item>();
        newItem.itemName = "Empty";
        newItem.itemImage = EmptySlot;
        newItem.itemType = ItemType.Empty;

        return newItem;
    }

    private Item CreateBeginItem()
    {
        Item newItem = ScriptableObject.CreateInstance<Item>();
        newItem.itemName = "Green";
        newItem.itemImage = StartItem;
        newItem.itemType = ItemType.Crop;

        return newItem;
    }

    public void SetSelected(Button button)
    {
        switch (button.name)
        {
            case "slot1":
                selectedslot = 0;
                SlotImg1.GetComponent<Image>().color = new Color32(255, 0, 0, 100);
                SlotImg2.GetComponent<Image>().color = new Color32(0, 0, 0, 100);
                SlotImg3.GetComponent<Image>().color = new Color32(0, 0, 0, 100);
                break;
            case "slot2":
                selectedslot = 1;
                SlotImg1.GetComponent<Image>().color = new Color32(0, 0, 0, 100);
                SlotImg2.GetComponent<Image>().color = new Color32(255, 0, 0, 100);
                SlotImg3.GetComponent<Image>().color = new Color32(0, 0, 0, 100);
                break;
            case "slot3":
                selectedslot = 2;
                SlotImg1.GetComponent<Image>().color = new Color32(0, 0, 0, 100);
                SlotImg2.GetComponent<Image>().color = new Color32(0, 0, 0, 100);
                SlotImg3.GetComponent<Image>().color = new Color32(255, 0, 0, 100);
                break;
        }
    }

    public void Add(Item item, GameObject itemObject)
    {
        if (item.itemType == ItemType.Tool)
        {
            if (items[0].itemName == "Empty")
            {
                items[0].itemName = item.name;
                items[0].itemImage = item.itemImage;
                Destroy(itemObject);
            }
        }

        if (item.itemType == ItemType.Crop)
        {
            if (items[1].itemName == "Empty")
            {
                items[1].itemName = item.name;
                items[1].itemImage = item.itemImage;
                Destroy(itemObject);
            }
            else
            {
                if (items[2].itemName == "Empty")
                {
                    items[2].itemName = item.name;
                    items[2].itemImage = item.itemImage;
                    Destroy(itemObject);
                }
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedslot = 0;
            SlotImg1.GetComponent<Image>().color = new Color32(255, 0, 0, 100);
            SlotImg2.GetComponent<Image>().color = new Color32(0, 0, 0, 100);
            SlotImg3.GetComponent<Image>().color = new Color32(0, 0, 0, 100);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            selectedslot = 1;
            SlotImg1.GetComponent<Image>().color = new Color32(0, 0, 0, 100);
            SlotImg2.GetComponent<Image>().color = new Color32(255, 0, 0, 100);
            SlotImg3.GetComponent<Image>().color = new Color32(0, 0, 0, 100);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            selectedslot = 2;
            SlotImg1.GetComponent<Image>().color = new Color32(0, 0, 0, 100);
            SlotImg2.GetComponent<Image>().color = new Color32(0, 0, 0, 100);
            SlotImg3.GetComponent<Image>().color = new Color32(255, 0, 0, 100);
        }

        SlotImg1.GetComponent<Image>().sprite = items[0].itemImage;
        SlotImg2.GetComponent<Image>().sprite = items[1].itemImage;
        SlotImg3.GetComponent<Image>().sprite = items[2].itemImage;


        if (Input.GetKeyDown(KeyCode.Q))
        {

            Debug.Log(items[selectedslot].itemName.ToString());

            switch (items[selectedslot].itemImage.ToString())
            {
                case "Green":
                    GameObject newObject = Instantiate(Green, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                case "Green Seed":
                    Instantiate(Green_Seed, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                case "Grass":
                    Instantiate(Grass, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                case "Grass Seed":
                    Instantiate(Grass_Seed, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                case "Wheat":
                    Instantiate(Wheat, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                case "Wheat Seed":
                    Instantiate(Wheat_Seed, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                case "Carrot":
                    Instantiate(Carrot, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                case "Carrot Seed":
                    Instantiate(Carrot_Seed, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                case "Potato":
                    Instantiate(Potato, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                case "Potato Seed":
                    Instantiate(Potato_Seed, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                case "Tomato":
                    Instantiate(Tomato, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                case "Tomato Seed":
                    Instantiate(Potato_Seed, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                case "Berrie":
                    Instantiate(berrie, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                case "Berrie Seed":
                    Instantiate(berrie_Seed, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                case "Melon":
                    Instantiate(Melon, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                case "Melon Seed":
                    Instantiate(Melon_Seed, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                case "Pumpkin":
                    Instantiate(Pumpkin, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                case "Pumpkin Seed":
                    Instantiate(Pumpkin_Seed, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                case "Beetroot":
                    Instantiate(Beetroot, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                case "Beetroot Seed":
                    Instantiate(Beetroot_Seed, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                case "Cabbage":
                    Instantiate(Cabbage, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                case "Cabbage Seed":
                    Instantiate(Cabbage_Seed, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                case "Spinach":
                    Instantiate(Spanich, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                case "Spinach Seed":
                    Instantiate(Spanich_Seed, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                case "Gieter":
                    Instantiate(Gieter, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                case "mortaronkruidverwijderaar":
                    Instantiate(mortaronkruidverwijderaar, new Vector3(0, 0, 0), Quaternion.identity);
                    break;              
            }
  
            items[selectedslot].itemName = "Empty";
            items[selectedslot].itemImage = EmptySlot;
        }
    }
}
