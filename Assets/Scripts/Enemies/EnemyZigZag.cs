using UnityEngine;

public class EnemyZigZag : MonoBehaviour
{
    public float speed = 7f;
    public float frquency = 3f;
    public float magnitude = 2f;

    private Vector3 startPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDir = Vector3.left * speed * Time.deltaTime;
        float zigzag = Mathf.Sin(Time.time * frquency) * magnitude;
        transform.position += moveDir + new Vector3(0, zigzag * Time.deltaTime, 0);
    }

    private void OnTriggerEngter2D(Collider2D other)
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
