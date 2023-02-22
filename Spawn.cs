using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform[] spawnpoints;
    public GameObject spawnableObject;

    public int spawnPointsLeg;

    public float spawnRate = 2f;
    public float timePassed;

    private void Start()
    {
        spawnPointsLeg = spawnpoints.Length;
    }

    private void Update()
    {
        timePassed += 1 * Time.deltaTime;

        if(timePassed >= spawnRate)
        {
            SpawnItem();
            timePassed = 0;
        }
    }

    void SpawnItem()
    {
        int randint = Random.Range(0, spawnPointsLeg - 1);

        Instantiate(spawnableObject, spawnpoints[randint].position, Quaternion.identity);
    }
}
