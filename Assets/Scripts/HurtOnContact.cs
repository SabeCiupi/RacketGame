using UnityEngine;

public class HurtOnContact : MonoBehaviour
{
    public int damage = 1;
    public string targetTag = "Player";

    public bool destroySelfOnHit = true;

    bool consumed;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (consumed) return;
        if (!other.CompareTag(targetTag)) return;

        var hs = other.GetComponent<HealthSystem>();
        if (hs != null)
        {
            hs.TakeDamage(damage);
            consumed = true;
            if (destroySelfOnHit) Destroy(gameObject);
        }
    }
}