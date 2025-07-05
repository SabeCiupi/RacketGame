using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float speed = 4.5f;

    void Update()
    {
        // move the bullet forward every frame
        transform.position += transform.up * Time.deltaTime * speed;
    }

    // the bullet hit an enemy (called when the bullet hits another collider)
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            // destroy the enemy
            Destroy(other.gameObject);
            // destroy the bullet
            Destroy(gameObject);
        }
    }

}

