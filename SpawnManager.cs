using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] gabbyPrefabs;
    public float xRange = 7.0f;
    public float yRange = 1.0f;
    public float zRange = 20.0f;
    public float spawnDelay = 2.0f;
    public float spawnRepeating = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnEnemy", spawnDelay, spawnRepeating);
    }

    // Update is called once per frame
    void Update()
    {
        
        
            
        
    }

    void spawnEnemy()
    {
        int gabbyIndex = Random.Range(0, gabbyPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange), yRange, zRange);


        Instantiate(gabbyPrefabs[gabbyIndex], spawnPos, gabbyPrefabs[gabbyIndex].transform.rotation);
    }

}
