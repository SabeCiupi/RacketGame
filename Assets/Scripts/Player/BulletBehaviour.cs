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
            // adding score for every hit
            Score.scoreValue += 10;

            // verify if has ArmoredEnemy script
            ArmoredEnemy armored = other.GetComponent<ArmoredEnemy>();

            if (armored)
            {
                armored.TakeDamage(); // apply damage
            }
            else
            {
                // destroy the enemy
                Destroy(other.gameObject);
            }
            
            // destroy the bullet
            Destroy(gameObject);
        }
        if (other.CompareTag("Planet"))
        {
            Destroy(gameObject);
        }
    }

}

