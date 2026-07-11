using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;

    [SerializeField]
    private float lifeTime = 3f;

    [SerializeField]
    private int damage = 1;

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

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Bullet Hit : " + other.name);

        Enemy enemy = other.GetComponent<Enemy>();

        if(enemy == null)
        {
            Debug.Log("Enemyではありません");
            return;
        }

        enemy.TakeDamage(damage);

        Destroy(gameObject);
    }
}