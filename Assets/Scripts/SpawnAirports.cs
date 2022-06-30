using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAirports : MonoBehaviour
{
    [SerializeField] private Vector3[] airports;
    [SerializeField] private float spawnRate = 30f;
    [SerializeField] private GameObject airport;

    private float nextSpawn = 0f;

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            Debug.Log("spawning");
            nextSpawn = Time.time + spawnRate;
            Vector3 airportPos = airports[Random.Range(0, airports.Length)];
            Vector3 spawnPos = new Vector3(airportPos.x, airportPos.y, airportPos.z);
            Instantiate(airport, spawnPos, Quaternion.identity);
        }
    }
}
