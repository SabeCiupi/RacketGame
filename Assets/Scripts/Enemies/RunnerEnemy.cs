using UnityEngine;

public class RunnerEnemy : MonoBehaviour
{
    public Vector2 direction = Vector2.left;
    public float speed = 14f;
    private Rigidbody2D rb;
    protected void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = direction.normalized * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player hit by enemy!");
        }

        if (other.CompareTag("Wall"))
        {
            HealthSystem playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthSystem>();
            playerHealth.TakeDamage(1);
            Destroy(gameObject); 
        }
    }
}
