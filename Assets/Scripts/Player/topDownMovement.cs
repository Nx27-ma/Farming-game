using UnityEngine;

public class topDownMovement : MonoBehaviour
{
    private float moveSpeed = 3.0f;

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
            transform.Translate(Pzoomies * Time.deltaTime * moveSpeed, Space.World);
    }
}
