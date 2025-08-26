using UnityEngine;
using UnityEngine.UI;
using System;
public class HealthSystem : MonoBehaviour
{
    [Header("Health")]
    public int maxHealth = 3;
    public int CurrentHealth { get; private set; }
    public bool IsDead { get; private set; }

    public event Action<int, int> OnHealthChanged;
    public event Action OnDeath;

    void Start()
    {
        CurrentHealth = maxHealth;
        OnHealthChanged?.Invoke(CurrentHealth, maxHealth);
    }

    public void TakeDamage(int amount)
    {
        if (IsDead) return;
        CurrentHealth = Mathf.Max(CurrentHealth - amount, 0);
         OnHealthChanged?.Invoke(CurrentHealth, maxHealth);
        if (CurrentHealth <= 0) Die();
    }

    private void Die()
    {
        IsDead = true;
        Destroy(gameObject);
    }

    public void Heal(int amount)
    {
        if (IsDead) return;
        CurrentHealth = Mathf.Min(CurrentHealth + amount, maxHealth);
        OnHealthChanged?.Invoke(CurrentHealth, maxHealth);
    }
}
