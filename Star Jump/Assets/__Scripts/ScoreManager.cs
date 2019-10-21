using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public TMP_Text timerText;
    public TMP_Text highScoreText;
    private float secondsCount;
    private static int score;
    private int score1, score2, score3;
    private bool stopTimer;
    private int highscore;
    public float timeLeft = 3.0f;

    void Start () {
        score1 = 0;
        score2 = 0;
        score3 = 0;
        GetHighScores ();
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

    public void SetScores () {
        stopTimer = true;
        if (SceneManager.GetActiveScene ().name == "Level1") {
            PlayerPrefs.SetInt ("Score1", score1);
            PlayerPrefs.SetInt ("Highscore1", highscore);
        } else if (SceneManager.GetActiveScene ().name == "Level2") {
            PlayerPrefs.SetInt ("Score2", score2);
            PlayerPrefs.SetInt ("Highscore2", highscore);
        } else if (SceneManager.GetActiveScene ().name == "Level3") {
            PlayerPrefs.SetInt ("Score3", score3);
            PlayerPrefs.SetInt ("Highscore3", highscore);
        }
    }
    public void GetHighScores () {
        if (SceneManager.GetActiveScene ().name == "Level1") {
            highscore = PlayerPrefs.GetInt ("Highscore1", 0);
            highScoreText.text = "High Score " + highscore;
        } else if (SceneManager.GetActiveScene ().name == "Level2") {
            highscore = PlayerPrefs.GetInt ("Highscore2", 0);
            highScoreText.text = "High Score " + highscore;
        } else if (SceneManager.GetActiveScene ().name == "Level3") {
            highscore = PlayerPrefs.GetInt ("Highscore3", 0);
            highScoreText.text = "High Score " + highscore;
        }
    }
    public void UpdateScore () {
        if (SceneManager.GetActiveScene ().name == "Level1") {
            score1 = (int) secondsCount;

            if (score1 > highscore) {
                highscore = score1;
            }
        } else if (SceneManager.GetActiveScene ().name == "Level2") {
            score2 = (int) secondsCount;

            if (score2 > highscore) {
                highscore = score2;
            }
        } else if (SceneManager.GetActiveScene ().name == "Level3") {
            score3 = (int) secondsCount;

            if (score3 > highscore) {
                highscore = score3;
            }
        }
    }
    public static int GetScores () {
        if (SceneManager.GetActiveScene ().name == "Level1") {
            score = PlayerPrefs.GetInt ("Score1");
        } else if (SceneManager.GetActiveScene ().name == "Level2") {
            score = PlayerPrefs.GetInt ("Score2");
        } else if (SceneManager.GetActiveScene ().name == "Level3") {
            score = PlayerPrefs.GetInt ("Score3");
        }
        return score;
    }
}