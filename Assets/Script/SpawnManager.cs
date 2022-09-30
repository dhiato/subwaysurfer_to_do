using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ObstaclePrefab;
    public GameObject ObstacleLowPrefab;

    
    public Vector2 spawnRangeX;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), 0.4f, 1.0f);
        InvokeRepeating(nameof(SpawnObstacleLow), 3, 4.0f);
    }

    private void SpawnObstacleLow()
    {
        Vector3 spawnPosition = new Vector3(
                ObstacleLowPrefab.transform.position.x,

            ObstacleLowPrefab.transform.position.y,
            ObstacleLowPrefab.transform.position.z);

        Instantiate(
            ObstacleLowPrefab,
            spawnPosition,
            ObstacleLowPrefab.transform.rotation);
    }
    // Update is called once per frame
    private void SpawnObstacle()
    {
        Vector3 spawnPosition = new Vector3(
            Random.Range(spawnRangeX[0], spawnRangeX[1]),
            ObstaclePrefab.transform.position.y,
            ObstaclePrefab.transform.position.z);

       
        Instantiate(
            ObstaclePrefab,
            spawnPosition,
            ObstaclePrefab.transform.rotation);
    }
}