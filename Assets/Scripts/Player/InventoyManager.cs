using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoyManager : MonoBehaviour
{
    public static InventoyManager instance;
    public List<Item> items = new List<Item>();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 public GameObject Green;public GameObject Grass;public GameObject Wheat;public GameObject Carrot;public GameObject Potato;public GameObject Tomato;public GameObject Berrie;public GameObject Melon;public GameObject Pumpkin;public GameObject Beetroot;public GameObject Cabbage;public GameObject Spinach;public GameObject Green_Seed;public GameObject Grass_Seed;public GameObject Wheat_Seed;public GameObject Carrot_Seed;public GameObject Potato_Seed;public GameObject Tomato_Seed;public GameObject Berrie_Seed;public GameObject Melon_Seed;public GameObject Pumpkin_Seed;public GameObject Beetroot_Seed;public GameObject Cabbage_Seed;public GameObject Spinach_Seed;public GameObject Gieter;public GameObject Onkruidverwijderaar;public int selectedslot;public GameObject SlotImg1;public GameObject SlotImg2;public GameObject SlotImg3; public GameObject SlotTxt1; public GameObject SlotTxt2; public GameObject SlotTxt3; public Sprite EmptySlot;public Sprite StartItem; public Transform Player;
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        GameObject WheatObj = Instantiate(Wheat);
        items.Add(CreateEmptyItem());
        items.Add(CreateBeginItem());
        items.Add(CreateBeginItem());
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
        newItem.itemName =  ItemName.Green_Seed;
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
            if (items[0].itemName == ItemName.Empty)
            {
                items[0].itemName = item.itemName;
                items[0].itemImage = item.itemImage;
                Destroy(itemObject);
            }
        }

        if (item.itemType == ItemType.Crop)
        {
            if (items[1].itemName == ItemName.Empty)
            {
                items[1].itemName = item.itemName;
                items[1].itemImage = item.itemImage;
                Destroy(itemObject);
            }
            else
            {
                if (items[2].itemName == ItemName.Empty)
                {
                    items[2].itemName = item.itemName;
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

        SlotTxt1.GetComponent<Text>().text = items[0].itemName.ToString();
        SlotTxt2.GetComponent<Text>().text = items[1].itemName.ToString();
        SlotTxt3.GetComponent<Text>().text = items[2].itemName.ToString();

        if (Input.GetKeyDown(KeyCode.Q))
        {
            switch (items[selectedslot].itemName.ToString())
            {
                case "Green":
                    GameObject GreenObj = Instantiate(Green);
                    GreenObj.transform.position = Player.position;
                    break;
                case "Green_Seed":
                    GameObject GreenSeedObj = Instantiate(Green_Seed);
                    GreenSeedObj.transform.position = Player.position;
                    break;
                case "Grass":
                    GameObject GrassObj = Instantiate(Grass);
                    GrassObj.transform.position = Player.position;
                    break;
                case "Grass_Seed":
                    GameObject GrassSeedObj = Instantiate(Grass_Seed);
                    GrassSeedObj.transform.position = Player.position;
                    break;
                case "Wheat":
                    GameObject WheatObj = Instantiate(Wheat);
                    WheatObj.transform.position = Player.position;
                    break;
                case "Wheat_Seed":
                    GameObject WheatSeedObj = Instantiate(Wheat_Seed);
                    WheatSeedObj.transform.position = Player.position;
                    break;
                case "Carrot":
                    GameObject CarrotObj = Instantiate(Carrot);
                    CarrotObj.transform.position = Player.position;
                    break;
                case "Carrot_Seed":
                    GameObject CarrotSeedObj = Instantiate(Carrot_Seed);
                    CarrotSeedObj.transform.position = Player.position;
                    break;
                case "Potato":
                    GameObject PotatoObj = Instantiate(Potato);
                    PotatoObj.transform.position = Player.position;
                    break;
                case "Potato_Seed":
                    GameObject PotatoSeedObj = Instantiate(Potato_Seed);
                    PotatoSeedObj.transform.position = Player.position;
                    break;
                case "Tomato":
                    GameObject TomatoObj = Instantiate(Tomato);
                    TomatoObj.transform.position = Player.position;
                    break;
                case "Tomato_Seed":
                    GameObject TomatoSeedObj = Instantiate(Tomato_Seed);
                    TomatoSeedObj.transform.position = Player.position;
                    break;
                case "Berrie":
                    GameObject BarrieObj = Instantiate(Berrie);
                    BarrieObj.transform.position = Player.position;
                    break;
                case "Berrie_Seed":
                    GameObject BerrieSeedObj = Instantiate(Berrie_Seed);
                    BerrieSeedObj.transform.position = Player.position;
                    break;
                case "Melon":
                    GameObject MelonObj = Instantiate(Melon);
                    MelonObj.transform.position = Player.position;
                    break;
                case "Melon_Seed":
                    GameObject MelonSeedObj = Instantiate(Melon_Seed);
                    MelonSeedObj.transform.position = Player.position;
                    break;
                case "Pumpkin":
                    GameObject PumpkinObj = Instantiate(Pumpkin);
                    PumpkinObj.transform.position = Player.position;
                    break;
                case "Pumpkin_Seed":
                    GameObject PumpkomSeedObj = Instantiate(Pumpkin_Seed);
                    PumpkomSeedObj.transform.position = Player.position;
                    break;
                case "Beetroot":
                    GameObject BeetrootObj = Instantiate(Beetroot);
                    BeetrootObj.transform.position = Player.position;
                    break;
                case "Beetroot_Seed":
                    GameObject BeetrootSeedObj = Instantiate(Beetroot_Seed);
                    BeetrootSeedObj.transform.position = Player.position;
                    break;
                case "Cabbage":
                    GameObject CabbgeObj = Instantiate(Cabbage);
                    CabbgeObj.transform.position = Player.position;
                    break;
                case "Cabbage_Seed":
                    GameObject CabbgeSeedObj = Instantiate(Cabbage_Seed);
                    CabbgeSeedObj.transform.position = Player.position;
                    break;
                case "Spinach":
                    GameObject SpinachObj = Instantiate(Spinach);
                    SpinachObj.transform.position = Player.position;
                    break;
                case "Spinach_Seed":
                    GameObject SpinachSeedObj = Instantiate(Spinach_Seed);
                    SpinachSeedObj.transform.position = Player.position;
                    break;
                case "Gieter":
                    GameObject GieterObj = Instantiate(Gieter);
                    GieterObj.transform.position = Player.position;
                    break;
                case "Onkruidverwijderaar":
                    GameObject OnkruidverwijderaarObj = Instantiate(Onkruidverwijderaar);
                    OnkruidverwijderaarObj.transform.position = Player.position;
                    break;              
            }
  
            items[selectedslot].itemName =  ItemName.Empty;
            items[selectedslot].itemImage = EmptySlot;
        }
    }
}
