using UnityEngine;

public class CollistionController : MonoBehaviour
{
    public Transform PlayerCheck;
    public Transform ShopCheck;
    public Transform ShedCheck;
    public Transform FarmHouseCheck;
    public GameObject ShopObject;
    public GameObject ShedObject;
    public GameObject FarmHouseObject;
    public GameObject ShopGui;
    public GameObject ShedGui;
    public GameObject FarmHouseGui;

    private void Update()
    {
        if (IsObjectInsideObject(PlayerCheck, ShopObject))
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePosition2D = new Vector2(mousePosition.x, mousePosition.y);

                if (IsMouseInsideObject(mousePosition2D, ShopCheck))
                {
                    ShopGui.SetActive(true);
                }
                else
                {
                    ShopGui.SetActive(false);
                }
            }
        }
        else
        {
            ShopGui.SetActive(false);
        }


        if (IsObjectInsideObject(PlayerCheck, ShedObject))
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePosition2D = new Vector2(mousePosition.x, mousePosition.y);

                if (IsMouseInsideObject(mousePosition2D, ShedCheck))
                {
                    ShedGui.SetActive(true);
                }
                else
                {
                    ShedGui.SetActive(false);
                }
            }
        }
        else
        {
            ShedGui.SetActive(false);
        }

        if (IsObjectInsideObject(PlayerCheck, FarmHouseObject))
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePosition2D = new Vector2(mousePosition.x, mousePosition.y);

                if (IsMouseInsideObject(mousePosition2D, FarmHouseCheck))
                {
                    FarmHouseGui.SetActive(true);
                }
                else
                {
                    FarmHouseGui.SetActive(false);
                }
            }
        }
        else
        {
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

