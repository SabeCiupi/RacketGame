using UnityEngine;

public class ChaserEnemy : MonoBehaviour
{
    public float speed = 5f;
    private Transform player;
    private Rigidbody2D rb;
    protected void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        if (playerObj)
        {
            player = playerObj.transform;
        }
    }

    void FixedUpdate()
    {
        if (player)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            rb.linearVelocity = direction * speed;
        }
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
