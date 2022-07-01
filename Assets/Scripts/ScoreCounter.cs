using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreCounter;
    public GameObject GameMng;
    private GameManage game;

    // Start is called before the first frame update
    void Start()
    {
        game = GameMng.GetComponent<GameManage>();
        game.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreCounter.text = "Score: " + (game.score).ToString();
    }
}
