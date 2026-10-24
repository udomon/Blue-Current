using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    //all for pink fish
    public GameObject[] fishPrefabs;   // fish prefabs to spawn
    public float spawnInterval = 2f; // seconds between spawns
    public float spawnX = 10f;       // fixed X position
    public float minY = -4f;         // minimum Y
    public float maxY = 4f;          // maximum Y

    void Start()
    {
        InvokeRepeating("SpawnFish", 0f, spawnInterval);
    }

    void SpawnFish()
    {
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPos = new Vector3(spawnX, randomY, 0);
        GameObject fish = fishPrefabs[Random.Range(0, fishPrefabs.Length)];
        Instantiate(fish, spawnPos, Quaternion.identity);

    }
}
