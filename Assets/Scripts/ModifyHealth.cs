using UnityEngine;

public class ModifyHealth : MonoBehaviour
{
    public int healthChange = -1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        HealthSystem health = collision.GetComponent<HealthSystem>();

        if (health != null)
        {
            health.TakeDamage(-healthChange);
            if (gameObject.CompareTag("Bullet"))
            {
                Destroy(gameObject);
            }
        }
    }
}
