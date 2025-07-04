using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float speed = 4.5f;

    void Update()
    {
        transform.position += transform.up * Time.deltaTime * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
