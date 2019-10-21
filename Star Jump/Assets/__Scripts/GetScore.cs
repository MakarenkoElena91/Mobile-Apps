using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetScore : MonoBehaviour {
    private int score;
    public TMP_Text scoreText;

    void Start () {
        score = ScoreManager.GetScores ();
        scoreText.text = "" + score;
    }
}