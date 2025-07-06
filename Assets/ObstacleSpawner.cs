using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject trashPrefab;
    public GameObject catPrefab;
    public float spawnInterval = 2f;
    public float yPosition = -3.5f; // Adjust to sit on road level
    public float xSpawn = 12f;

    private bool spawnTrashNext = true;

    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), 1f, spawnInterval);
    }

    void SpawnObstacle()
    {
        GameObject prefabToSpawn = spawnTrashNext ? trashPrefab : catPrefab;

        Vector3 spawnPos = new Vector3(xSpawn, yPosition, 0f);
        Instantiate(prefabToSpawn, spawnPos, Quaternion.identity);

        spawnTrashNext = !spawnTrashNext; // Alternate next spawn
    }
}

