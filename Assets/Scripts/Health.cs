using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] private int startHealth = 20;
    [SerializeField] private HealthBar healthbar;
    [SerializeField] private GameObject explosion;
    public GameObject GameMng;
    private GameManage game;
    
    private int health;

    // Start is called before the first frame update
    void Start()
    {
        game = GameMng.GetComponent <GameManage>();
        health = startHealth;
    }

    

    public void takeDamage(int dmg)
    {
        health -= dmg;
        healthbar.UpdateHealth((float)health / (float)startHealth);
        if(health == 0)
        {

            GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;

            if(gameObject.tag == "Player")
            {
                game.playerAlive = false;
                Destroy(gameObject);
            }
            else
            {
                Debug.Log(game.score);
                game.score += 1;
                Destroy(gameObject);
            }
            

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
