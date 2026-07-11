using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 3f;

    [SerializeField]
    private int maxHP = 1;

    private int currentHP;

    private Transform player;

    private void Start()
    {
        currentHP = maxHP;

        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if (player == null)
            return;

        Vector2 direction =
            (player.position - transform.position).normalized;

        transform.position +=
            (Vector3)(direction * moveSpeed * Time.deltaTime);
    }

    public void TakeDamage(int damage)
    {
        Debug.Log("④ TakeDamage");

        currentHP -= damage;

        Debug.Log(currentHP);

        if(currentHP <= 0)
        {
            Debug.Log("⑤ Die");
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}