using UnityEngine;

public class topDownMovement : MonoBehaviour
{
    private float moveSpeed = 3.0f;

    public GameObject WorldBorder;
    public Transform Player;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 zoomies = new Vector2(horizontal, vertical);

        goZoomies(zoomies);
    }

    void goZoomies(Vector2 Pzoomies)
    {
        Debug.Log(IsObjectInsideObject(Player, WorldBorder));
        if (IsObjectInsideObject(Player, WorldBorder))
        {
            transform.Translate(Pzoomies * Time.deltaTime * moveSpeed, Space.World);
        }
    }

    private bool IsObjectInsideObject(Transform objectTransform, GameObject otherGameObject)
    {
        Collider2D objectCollider = objectTransform.GetComponent<Collider2D>();
        Collider2D otherCollider = otherGameObject.GetComponent<Collider2D>();

        return otherCollider.bounds.Contains(objectCollider.bounds.min) && otherCollider.bounds.Contains(objectCollider.bounds.max);
    }
}
