using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{
    [SerializeField] private GameObject wordPrefab;
    [SerializeField] private Transform wordCanvas;

    public WordDisplay SpawnWord()
    {
        Vector3 randomPos = new Vector3(Random.Range(-4f, 4f), 6f);

        GameObject wordObject = Instantiate(wordPrefab, randomPos, Quaternion.identity, wordCanvas);
        WordDisplay wordDisplay = wordObject.GetComponent<WordDisplay>();

        return wordDisplay;
    }
}
