using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        // move the obstacle to the left every frame
        transform.position += Vector3.left * speed * Time.deltaTime;
        // destroy the obstacle if it moves off-screen
        if (transform.position.x < -35f)
        {
            Destroy(gameObject);
        }
    }
}
