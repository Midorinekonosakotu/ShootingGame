using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;

    [SerializeField]
    private float lifeTime = 3f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Initialize(Vector2 direction)
    {
        rb.linearVelocity = direction.normalized * speed;

        Destroy(gameObject, lifeTime);
    }
}