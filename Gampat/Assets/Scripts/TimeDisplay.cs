using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text timeText;
    [SerializeField] private TMP_Text endTimeText;

    private float timeNumber = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeNumber += Time.deltaTime;
        DisplayTime();
    }

    void DisplayTime()
    {
        int minutes = Mathf.FloorToInt(timeNumber / 60.0f);
        int seconds = Mathf.FloorToInt(timeNumber - minutes * 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void ShowLastTime()
    {
        endTimeText.text = timeText.text;
        DisplayTime();
    }
}
