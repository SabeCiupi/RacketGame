using UnityEngine;
using UnityEngine.UI;


public class HealthUI : MonoBehaviour
{
    public Sprite emptyHeart;
    public Sprite fullHeart;
    public Image[] hearts;

    [SerializeField] private HealthSystem healthSystem;

    void Start()
    {
        if (healthSystem == null) healthSystem = FindObjectOfType<HealthSystem>();

        healthSystem.OnHealthChanged += UpdateHearts;
        UpdateHearts(healthSystem.CurrentHealth, healthSystem.maxHealth);
    }

    private void UpdateHearts(int currentHealth, int maxHealth)
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < currentHealth)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < maxHealth)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}