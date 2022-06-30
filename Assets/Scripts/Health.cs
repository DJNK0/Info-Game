using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private int startHealth = 20;
    [SerializeField] private HealthBar healthbar;

    private int health;

    // Start is called before the first frame update
    void Start()
    {
        health = startHealth;
    }

    public void takeDamage(int dmg)
    {
        health -= dmg;
        healthbar.UpdateHealth((float)health / (float)startHealth);
    }

    private void OnTriggerEnter(Collider col)
    {
        Destroy(col.gameObject);
        takeDamage(1);
        Debug.Log(startHealth);
    }
}
