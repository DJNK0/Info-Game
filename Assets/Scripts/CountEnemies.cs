using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountEnemies : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI counterTextPlane;
    [SerializeField] private TextMeshProUGUI counterTextAirport;
    private GameObject[] enemies;
    private GameObject[] airport;


    void LateUpdate()
    {
        enemies = GameObject.FindGameObjectsWithTag("enemy");
        airport = GameObject.FindGameObjectsWithTag("airport");
        
        counterTextPlane.text = (enemies.Length).ToString();
        counterTextAirport.text = (airport.Length).ToString();
    }
}
