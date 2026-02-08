using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    private int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;

    public List<GameObject> targets;
    private float spawnRate;

    public GameObject titleScreen;

    public bool isGameActive;
    private void Start()
    {

    }
    private IEnumerator SpawnTarget()
    {
        spawnRate = 1f;
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }
    public void UpdateScore(int scoreCounter)
    {
        score += scoreCounter;
        scoreText.text = "Score: " + score;
    }
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void StartGame(int difficulty)
    {
        isGameActive = true;
        StartCoroutine(SpawnTarget());
        spawnRate /= difficulty;
        score = 0;
        UpdateScore(0);

        titleScreen.gameObject.SetActive(false);
    }
}
