using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public Text timerText;
    private float secondsCount;
    private int score;
    private bool stopTimer;
    private int highscore;
    public Text highScoreText;

    void Start () {
        score = 0;
        highscore = PlayerPrefs.GetInt ("Highscore", 0);
        highScoreText.text = "" + highscore;
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
        timerText.text = "" + (int) secondsCount;
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