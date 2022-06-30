using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPlanes : MonoBehaviour
{
    [SerializeField] private float spawnRate = 30f;
    [SerializeField] private GameObject plane;

    private float nextSpawn = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            Vector3 spawnPos = new Vector3(transform.position.x, 43.9f, transform.position.z);

            Instantiate(plane, spawnPos, Quaternion.identity);
        }
    }
}
