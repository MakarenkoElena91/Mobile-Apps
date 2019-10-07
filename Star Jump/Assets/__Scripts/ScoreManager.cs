using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public TMP_Text timerText;
    public TMP_Text highScoreText;
    private float secondsCount;
    private int score;
    private bool stopTimer;
    private int highscore;
    public float timeLeft = 3.0f;

    void Start () {
        score = 0;
        highscore = PlayerPrefs.GetInt ("Highscore", 0);
        highScoreText.text = "High Score " + highscore;
        stopTimer = false;
    }

    void FixedUpdate () {
        timeLeft -= Time.deltaTime;
        if (!stopTimer) {
            UpdateTimerUI ();
        }
        UpdateScore ();
    }

    public void UpdateTimerUI () {
        if (timeLeft < 0) {
            //set timer UI
            secondsCount += Time.deltaTime;
            timerText.text = "Score " + (int) secondsCount;
        } else timerText.text = "Score 0";
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