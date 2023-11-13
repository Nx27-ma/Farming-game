using UnityEngine;

public class CollistionController : MonoBehaviour
{
    public Transform PlayerCheck;
    public Transform ShopCheck;
    public Transform ShedCheck;
    public Transform FarmHouseCheck;

    public Transform ShopGuiCheck;
    public Transform ShedGuiCheck;
    public Transform FarmHouseGuiCheck;
    public Transform HotbarGuiCheck;

    public GameObject ShopFloorObject;
    public GameObject ShedFloorObject;
    public GameObject FarmHouseFloorObject;
    public GameObject ShopRoofObject;
    public GameObject ShedRoofObject;
    public GameObject FarmHouseRoofObject;

    public GameObject ShopGui;
    public GameObject ShedGui;
    public GameObject FarmHouseGui;

    private float checkRadius = 2f;

    private void Update()
    {
        if (IsObjectInsideObject(PlayerCheck, ShopFloorObject))
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePosition2D = new Vector2(mousePosition.x, mousePosition.y);

                if (IsMouseInsideObject(mousePosition2D, ShopCheck) || IsMouseInsideObject(mousePosition2D, ShopGuiCheck) || IsMouseInsideObject(mousePosition2D, HotbarGuiCheck))
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

                if (IsMouseInsideObject(mousePosition2D, ShedCheck) || IsMouseInsideObject(mousePosition2D, ShedGuiCheck) || IsMouseInsideObject(mousePosition2D, HotbarGuiCheck))
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

                if (IsMouseInsideObject(mousePosition2D, FarmHouseCheck) || IsMouseInsideObject(mousePosition2D, FarmHouseGuiCheck) || IsMouseInsideObject(mousePosition2D, HotbarGuiCheck))
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
}

