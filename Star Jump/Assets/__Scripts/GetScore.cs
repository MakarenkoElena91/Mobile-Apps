using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetScore : MonoBehaviour
{
    private int score;
    public TMP_Text scoreText;
    void Start()
    {
        score = PlayerPrefs.GetInt("Score");
        scoreText.text = "" + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
