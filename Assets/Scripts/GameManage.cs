using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
    public int score = 0;
    public bool playerAlive = true;

    IEnumerator die()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Menu");
    }

    private void Update()
    {
        if (playerAlive == false)
        {
            StartCoroutine(die());
        }
    }
}
