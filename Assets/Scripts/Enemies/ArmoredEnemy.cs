using UnityEngine;

public class ArmoredEnemy : Enemy
{
    public int health = 2;
    public Sprite armoredSprite;
    public Sprite damagedSprite;

    private SpriteRenderer sr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected void Start()
    {
        base.Start();
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = armoredSprite;
    }

    public void TakeDamage()
    {
        health--;
        if (health == 1)
        {
            sr.sprite = damagedSprite;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
