using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    [SerializeField] private List<Word> words;

    private bool hasActiveWord;
    private Word activeWord;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetRandomWord(), GetComponent<WordSpawner>().SpawnWord());

        words.Add(word);
    }

    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
        else
        {
            foreach (Word word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        WordTyped();
    }

    private void WordTyped()
    {
        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
            FindObjectOfType<ScoreDisplay>().AddScore(activeWord.word.Length);
        }
    }
}
