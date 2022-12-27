using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WordDisplay : MonoBehaviour
{
    public float fallSpeed;
    [SerializeField] private GameObject explodeVFX;
    private TextMeshProUGUI wordText;

    private void Awake()
    {
        wordText = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        wordText.fontSize = Random.Range(55, 80);
    }

    private void Update()
    {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
    }

    public void SetWord(string word)
    {
        wordText.text = word;
    }

    public void RemoveLetter()
    {
        wordText.text = wordText.text.Remove(0, 1);
        wordText.color = new Color32(255, 76, 76, 255);
    }

    public void RemoveWord()
    {
        Instantiate(explodeVFX, transform.position, Quaternion.identity);
        FindObjectOfType<MusicPlayer>().PlayAudio();
        Destroy(gameObject);
    }
}
