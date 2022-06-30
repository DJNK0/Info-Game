using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirportExplosion : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "bomb")
        {

            Destroy(gameObject);
        }
    }
}
