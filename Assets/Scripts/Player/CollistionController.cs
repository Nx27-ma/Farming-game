using System.Collections.Generic;
using UnityEngine;


public class CollistionController : MonoBehaviour
{
    public List<GameObject> PlotObjs = new List<GameObject>();
    public List<Plots> ScriptPlotObjs = new List<Plots>();
    public List<GameObject> PlotGuis = new List<GameObject>();
    public List<GameObject> PlotImages = new List<GameObject>();
    public List<GameObject> FarmFieldGuis = new List<GameObject>();
    public List<GameObject> FarmFieldImages = new List<GameObject>();

    public int[,] FarmLandIndex;

    public Transform PlayerCheck;
    public Transform ShopCheck;
    public Transform ShedCheck;
    public Transform FarmHouseCheck;

    public UnityEngine.UI.Image ShopGuiCheck;
    public UnityEngine.UI.Image ShedGuiCheck;
    public UnityEngine.UI.Image FarmHouseGuiCheck;
    public UnityEngine.UI.Image HotbarGuiCheck;


    public GameObject ShopFloorObject;
    public GameObject ShedFloorObject;
    public GameObject FarmHouseFloorObject;
    public GameObject ShopRoofObject;
    public GameObject ShedRoofObject;
    public GameObject FarmHouseRoofObject;

    public GameObject ShopGui;
    public GameObject ShedGui;
    public GameObject FarmHouseGui;

    private void Start()
    {
        FarmLandIndex = new int[9, 4];

        int Count = 0;
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                FarmLandIndex[i, j] = Count;
                Count++;
            }
        }
    }

    private void Update()
    {
        if (IsObjectInsideObject(PlayerCheck, ShopFloorObject))
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePosition2D = new Vector2(mousePosition.x, mousePosition.y);

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

        for (int i = 0; i < PlotObjs.Count; i++)
        {
            if (IsObjectInsideObject(PlayerCheck, PlotObjs[i]))
            {
                
                var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                var mousePosition2D = new Vector2(mousePosition.x, mousePosition.y);

                if (ScriptPlotObjs[i].Gekocht)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (IsObjectInsideObject(PlayerCheck, PlotObjs[i].transform.GetChild(j).gameObject))
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                if (IsMouseInsideObject(mousePosition2D, PlotObjs[i].transform.GetChild(j)) || IsMouseInsideObject(mousePosition2D, FarmFieldImages[FarmLandIndex[i, j]].transform)) FarmFieldGuis[FarmLandIndex[i, j]].SetActive(true);
                                else FarmFieldGuis[FarmLandIndex[i, j]].SetActive(false);
                            }
                        }
                        else FarmFieldGuis[FarmLandIndex[i, j]].SetActive(false);
                    }
                }
                else
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        Debug.Log(IsMouseInsideObject(mousePosition2D, PlotImages[i].transform));
                        if (IsMouseInsideObject(mousePosition2D, PlotObjs[i].transform) || IsMouseInsideObject(mousePosition2D, PlotObjs[i].transform.GetChild(0)) ||
                        IsMouseInsideObject(mousePosition2D, PlotObjs[i].transform.GetChild(1)) || IsMouseInsideObject(mousePosition2D, PlotObjs[i].transform.GetChild(2)) ||
                        IsMouseInsideObject(mousePosition2D, PlotObjs[i].transform.GetChild(3)) || IsMouseInsideObject(mousePosition2D, PlotImages[i].transform))
                        {
                            PlotGuis[i].SetActive(true);
                        }
                        else PlotGuis[i].SetActive(false);
                    }
                }   
            }
            else PlotGuis[i].SetActive(false);
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

        if (objectCollider != null && otherCollider != null)
        {
            var objectBounds = new Bounds(objectCollider.bounds.center, objectCollider.bounds.size);
            var transformedObjectBounds = objectBounds;
            transformedObjectBounds.center = objectTransform.TransformPoint(objectBounds.center);
            transformedObjectBounds.size = objectTransform.TransformVector(objectBounds.size);

            return otherCollider.bounds.Contains(objectCollider.bounds.min) && otherCollider.bounds.Contains(objectCollider.bounds.max);
        }
        else
        {
            // Handle the case where either collider is null
            return false;
        }
    }

    bool IsMouseOverImage(UnityEngine.UI.Image uiImage)
    {
        if (uiImage == null)
        {
            return false;
        }

        RectTransform rectTransform = uiImage.rectTransform;

        RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform, Input.mousePosition, Camera.main, out Vector2 localMousePosition);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform == rectTransform)
            {
                return true;
            }
        }

        return false;
    }
}