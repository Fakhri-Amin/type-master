using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour
{
    [SerializeField] private float timeDelay = 1.5f;

    private WordManager wordManager;

    private void Awake()
    {
        wordManager = GetComponent<WordManager>();
        StartCoroutine(StartSpawning());
    }

    void Start()
    {

    }

    IEnumerator StartSpawning()
    {
        while (true)
        {
            wordManager.AddWord();
            yield return new WaitForSeconds(timeDelay);
            timeDelay *= 0.99f;
        }
    }
}
