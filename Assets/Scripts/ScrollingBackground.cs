using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float speed; // how fast the background scrolls

    [SerializeField]
    private Renderer bgRenderer;
    void Update()
    {
        // shifts the texture horizontallu over time
        bgRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
