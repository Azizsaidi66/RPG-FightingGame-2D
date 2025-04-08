using UnityEngine;

public class ItemsSpawner : MonoBehaviour
{
    public GameObject[] itemsPrefab;

    void Start()
    {
        InvokeRepeating("SpawnItem", 0f, 10f);
    }

    void SpawnItem()
    {
        int numItem = Random.Range(0, itemsPrefab.Length);
        Instantiate(itemsPrefab[numItem], new Vector2(Random.Range(-40f, 40f), Random.Range(-50f, 50f)), Quaternion.identity);
    }
}
