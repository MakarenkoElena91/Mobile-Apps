using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour {
    public TMP_Text timerText;
    public TMP_Text highScoreText;
    private float secondsCount;
    private int score;
    private bool stopTimer;
    private int highscore;
    
    void Start () {
        score = 0;
        highscore = PlayerPrefs.GetInt ("Highscore", 0);
        highScoreText.text = "High Score " + highscore;
        stopTimer = false;
    }

    void Update () {
        if (!stopTimer) {
            UpdateTimerUI ();
        }
        UpdateScore ();
    }

    public void UpdateTimerUI () {
        //set timer UI
        secondsCount += Time.deltaTime;
        timerText.text = "Score " + (int) secondsCount;
    }

    public void setScores () {
        stopTimer = true;
        PlayerPrefs.SetInt ("Score", score);
        PlayerPrefs.SetInt ("Highscore", highscore);
    }

    public void UpdateScore () {
        score = (int) secondsCount;

        if (score > highscore) {
            highscore = score;
        }
    }
}