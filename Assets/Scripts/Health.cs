using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private int startHealth = 20;
    [SerializeField] private HealthBar healthbar;
    [SerializeField] private GameObject explosion;
    [SerializeField]

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
        if(health == 0)
        {
            GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
            Destroy(gameObject);

            Destroy(expl, 1);
            

        }
    }

    private void OnTriggerEnter(Collider col)
    {
        Destroy(col.gameObject);
        takeDamage(1);
        Debug.Log(startHealth);
    }
}
