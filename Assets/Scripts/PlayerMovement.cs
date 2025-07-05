using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed; // player speed
    public Rigidbody2D rb; // the physical object of the player
    private Vector2 moveDirection; // the direction of movement

    public BulletBehaviour bulletPrefab; // the projectile
    public Transform LauchOffset; // the point from which the bullet leaves


    void Update()
    {
        ProcessInputs();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot(); // creates a bullet
        }
    }

    void FixedUpdate()
    {
        Move();
    }

    // verify which key was pressed
    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // creates a direction vector normalized for constant speed
        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    // it applies the player's speed
    void Move()
    {
        rb.linearVelocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    // shoots a bullet forward
    void Shoot()
    {
        Instantiate(bulletPrefab, LauchOffset.position, LauchOffset.rotation);
    }
}
