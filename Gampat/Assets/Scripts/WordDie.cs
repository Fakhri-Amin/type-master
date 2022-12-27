using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordDie : MonoBehaviour
{
    public bool hasDied;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -4.9f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }

}
