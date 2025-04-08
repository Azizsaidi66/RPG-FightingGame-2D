using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player")?.transform;
        InvokeRepeating("SpawnEnemy", 0f, 5f);
    }

    void SpawnEnemy()
    {
        if (player == null) return;
        int numEnemy = Random.Range(0, enemyPrefab.Length);
        GameObject enemy = Instantiate(enemyPrefab[numEnemy], new Vector2(Random.Range(-20f, 20f), 20f), Quaternion.identity);
        enemy.GetComponent<EnemyMovement>().SetPlayer(player);
    }
}