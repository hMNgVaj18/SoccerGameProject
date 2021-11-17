using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    public Text TimerText;
    public int MatchTime = 120;
    private float StartTime = 0;
    private int Scores = 0;
    private bool MatchActive = false;

    void Start()
    {
        SetTimeDisplay(MatchTime);
        StartTime = Time.time;
        MatchActive = true;

    }
    public void IncrementScore()
    {
        if (MatchActive)
        {
            Scores++;
            ScoreText.text = Scores.ToString() + " - ";
        }
    }
    
    void Update()
    {
        if (Time.time-StartTime < MatchTime)
        {
            float ElapseTime = Time.time - StartTime;
            SetTimeDisplay(MatchTime - ElapseTime);

        }
        else
        {
            MatchActive = false;
            SetTimeDisplay(0);
        }
        
    }

    private void SetTimeDisplay(float TimeDisplay)
    {
        TimerText.text = "Time: " + GetTimeDisplay(TimeDisplay);

    }

    private string GetTimeDisplay(float TimeToShow)
    {
        int SecondsToShow = Mathf.CeilToInt(TimeToShow);
        int Seconds = SecondsToShow % 60;
        string SecondsDisplay = (Seconds < 10) ? "0" + Seconds.ToString(): Seconds.ToString();
        int Minutes = (SecondsToShow - Seconds) / 60;
        return Minutes.ToString() + ":" + SecondsDisplay ;

    }



}
