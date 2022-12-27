using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public void SetNounLevel()
    {
        FindObjectOfType<WordGenerator>().SetNoun();
    }

    public void SetVerbLevel()
    {
        FindObjectOfType<WordGenerator>().SetVerb();
    }

    public void SetAdjectiveLevel()
    {
        FindObjectOfType<WordGenerator>().SetAdjective();
    }

    public void SetRandomWordsLevel()
    {
        FindObjectOfType<WordGenerator>().SetRandomWords();
    }
}
