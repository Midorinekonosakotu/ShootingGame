using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;

    [SerializeField]
    private Transform firePoint;

    [SerializeField]
    private float interval = 0.2f;

    [SerializeField]
    private float shotAngle = 90f;

    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetKey(KeyCode.Space))
        {
            if (timer >= interval)
            {
                Shoot();
                timer = 0;
            }
        }
    }

    private void Shoot()
    {
        float rad = shotAngle * Mathf.Deg2Rad;

        Vector2 direction = new Vector2(
            Mathf.Cos(rad),
            Mathf.Sin(rad)
        );

        GameObject bullet = Instantiate(
            bulletPrefab,
            firePoint.position,
            Quaternion.identity);

        bullet.GetComponent<Bullet>().Initialize(direction);
    }
}