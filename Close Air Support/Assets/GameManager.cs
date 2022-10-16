using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int enemyCount;
    public int score;
    public GameObject winUI;
    // Start is called before the first frame update
    private void OnEnable()
    {
        EnemyAI.onDeath += increasScore;
    }

    private void OnDisable()
    {
        EnemyAI.onDeath -= increasScore;
    }

    void Start()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }

    public void increasScore()
    {
        score += 1;

        if(score >= enemyCount)
        {
            winUI.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
