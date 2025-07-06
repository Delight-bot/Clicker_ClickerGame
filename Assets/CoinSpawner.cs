using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject[] coinPrefabs;  // Array to hold bronze, silver, gold
    public float spawnInterval = 2f;
    public float yMin = -2f, yMax = 2f;
    public float xSpawn = -12f; // Off-screen left

    void Start()
    {
        InvokeRepeating(nameof(SpawnCoin), 1f, spawnInterval);
    }

    void SpawnCoin()
    {
        if (coinPrefabs.Length == 0)
        {
            Debug.LogError("Its not working");
            return;
        }

        // Pick random coin prefab
        int index = Random.Range(0, coinPrefabs.Length);
        GameObject selectedCoin = coinPrefabs[index];

        float yPos = Random.Range(yMin, yMax);
        Vector3 spawnPos = new Vector3(xSpawn, yPos, 0f);

        Instantiate(selectedCoin, spawnPos, Quaternion.identity);
    }
}
