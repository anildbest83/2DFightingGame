using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    [SerializeField] private Transform firePoint;
    public bool hasPowerUpActivated;

    private Rigidbody2D rb;

    public Camera cam;

    public Vector2 movement;
    Vector2 mousePos;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        if (hasPowerUpActivated)
        {

        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
