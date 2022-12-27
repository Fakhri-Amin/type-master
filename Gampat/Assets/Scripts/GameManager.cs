using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverCanvas;

    private ColorGrading colorGrading;

    // Start is called before the first frame update
    void Start()
    {
        gameOverCanvas.SetActive(false);
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        FindObjectOfType<WordSpawner>().enabled = false;
        FindObjectOfType<ScoreDisplay>().ShowGameOverScore();
        FindObjectOfType<TimeDisplay>().ShowLastTime();
        Time.timeScale = 0f;
    }

}
