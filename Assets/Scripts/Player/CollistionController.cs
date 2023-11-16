using UnityEngine;
using UnityEngine.UI;

public class CollistionController : MonoBehaviour
{
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