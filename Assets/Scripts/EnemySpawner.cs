using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;

    [SerializeField]
    private Transform[] spawnPoints;

    [SerializeField]
    private float interval = 2f;

    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= interval)
        {
            SpawnEnemy();
            timer = 0f;
        }
    }

    private void SpawnEnemy()
    {
        int index = Random.Range(0, spawnPoints.Length);

        Instantiate(
            enemyPrefab,
            spawnPoints[index].position,
            Quaternion.identity);
    }
}