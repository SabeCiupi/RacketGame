using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    [Header("Health")]
    public int maxHealth = 3;
    public int CurrentHealth { get; private set; }

    bool isDead;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CurrentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        if (isDead) return;
        CurrentHealth = Mathf.Max(CurrentHealth - amount, 0);
        if (CurrentHealth <= 0) Die();
    }

    private void Die()
    {
        isDead = true;
        Destroy(gameObject);
    }

    public void Heal(int amount)
    {
        if (isDead) return;
        CurrentHealth = Mathf.Min(CurrentHealth + amount, maxHealth);
    }
}
