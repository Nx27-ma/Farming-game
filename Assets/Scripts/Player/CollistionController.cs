using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CollistionController : MonoBehaviour
{
    public List<GameObject> PlotObjs = new List<GameObject>();
    public List<Plots> PlotScriptObjs = new List<Plots>();
    public List<GameObject> FarmFieldObjs = new List<GameObject>();

    private int[,] my2DArray;

    public GameObject PlotGui;
    public TextMeshProUGUI PlotText;

    public GameObject FarmFieldGui;
    public TextMeshProUGUI FarmFieldText;

    public Transform PlayerCheck;
    public Transform ShopCheck;
    public Transform ShedCheck;
    public Transform FarmHouseCheck;

    public Image ShopGuiCheck;
    public Image ShedGuiCheck;
    public Image FarmHouseGuiCheck;
    public Image HotbarGuiCheck;

    public GameObject ShopFloorObject;
    public GameObject ShedFloorObject;
    public GameObject FarmHouseFloorObject;
    public GameObject ShopRoofObject;
    public GameObject ShedRoofObject;
    public GameObject FarmHouseRoofObject;

    public GameObject ShopGui;
    public GameObject ShedGui;
    public GameObject FarmHouseGui;

    private void Update()
    {
        if (IsObjectInsideObject(PlayerCheck, ShopFloorObject))
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePosition2D = new Vector2(mousePosition.x, mousePosition.y);

                Debug.Log(IsMouseOverImage(ShopGuiCheck));
                Debug.Log(IsMouseOverImage(HotbarGuiCheck));

                if (IsMouseInsideObject(mousePosition2D, ShopCheck) || IsMouseOverImage(ShopGuiCheck) || IsMouseOverImage(HotbarGuiCheck))
                {
                    ShopGui.SetActive(true);
                }
                else
                {
                    ShopGui.SetActive(false);
                }
            }
            ShopRoofObject.SetActive(false);
        }
        else
        {
            ShopRoofObject.SetActive(true);
            ShopGui.SetActive(false);
        }


        if (IsObjectInsideObject(PlayerCheck, ShedFloorObject))
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePosition2D = new Vector2(mousePosition.x, mousePosition.y);

                if (IsMouseInsideObject(mousePosition2D, ShedCheck) || IsMouseOverImage(ShedGuiCheck) || IsMouseOverImage(HotbarGuiCheck))
                {
                    ShedGui.SetActive(true);
                }
                else
                {
                    ShedGui.SetActive(false);
                }
            }
            ShedRoofObject.SetActive(false);
        }
        else
        {
            ShedRoofObject.SetActive(true);
            ShedGui.SetActive(false);
        }

        if (IsObjectInsideObject(PlayerCheck, FarmHouseFloorObject))
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePosition2D = new Vector2(mousePosition.x, mousePosition.y);

                if (IsMouseInsideObject(mousePosition2D, FarmHouseCheck) || IsMouseOverImage(FarmHouseGuiCheck) || IsMouseOverImage(HotbarGuiCheck))
                {
                    FarmHouseGui.SetActive(true);
                }
                else
                {
                    FarmHouseGui.SetActive(false);
                }
            }
            FarmHouseRoofObject.SetActive(false);
        }
        else
        {
            FarmHouseRoofObject.SetActive(true);
            FarmHouseGui.SetActive(false);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePosition2D = new Vector2(mousePosition.x, mousePosition.y);

            for (int i = 0; i < PlotObjs.Count; i++)
            {
                Debug.Log(IsMouseInsideObject(mousePosition2D, PlotObjs[i].transform));
                if (IsMouseInsideObject(mousePosition2D, PlotObjs[i].transform))
                {
                    if (PlotScriptObjs[0].Gekocht == false)
                    {
                        int value = 0;
                        for (int g = 0; g < 8; g++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                my2DArray[i, j] = value;
                                value++;
                            }
                        }
                        for (int n = 0; n < 4; n++)
                        {
                            if (IsMouseInsideObject(mousePosition2D, FarmFieldObjs[my2DArray[i, n]].transform))
                            {
                                FarmFieldText.text = FarmFieldObjs[my2DArray[i, n]].name;
                                FarmFieldGui.SetActive(true);
                            }
                        }
                    }
                    else
                    {
                        PlotText.text = PlotObjs[i].name;
                        PlotGui.SetActive(true);
                    }
                    PlotGui.SetActive(false);
                    FarmFieldGui.SetActive(false);
                }
            }
        }
    }
    
    private bool IsMouseInsideObject(Vector2 mousePosition, Transform objectTransform)
    {
        Collider2D objectCollider = objectTransform.GetComponent<Collider2D>();

        return objectCollider.bounds.Contains(mousePosition);
    }

    private bool IsObjectInsideObject(Transform objectTransform, GameObject otherGameObject)
    {
        Collider2D objectCollider = objectTransform.GetComponent<Collider2D>();
        Collider2D otherCollider = otherGameObject.GetComponent<Collider2D>();

        return otherCollider.bounds.Contains(objectCollider.bounds.min) && otherCollider.bounds.Contains(objectCollider.bounds.max);
    }

    bool IsMouseOverImage(Image uiImage)
    {
        if (uiImage == null)
        {
            return false;
        }

        RectTransform rectTransform = uiImage.rectTransform;

        Vector2 localMousePosition;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform, Input.mousePosition, null, out localMousePosition);

        if (rectTransform.rect.Contains(localMousePosition))
        {
            return true;
        }

        return false;
    }
}