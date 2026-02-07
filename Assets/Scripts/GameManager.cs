using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;

    public List<GameObject> targets;
    private float spawnRate;

    private void Start()
    {
        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(0);

    }
    private IEnumerator SpawnTarget()
    {
        spawnRate = Random.Range(1, 3);
        while (true)
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
}
